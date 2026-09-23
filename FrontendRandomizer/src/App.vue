<script setup>
import { ref, computed, onMounted } from 'vue'

const randomWeapon = ref(null)
const gameState = ref("idle")
const rollHistory = ref([])
const allWeapons = ref([])

const weaponWeights = ref({})
const showWeight = ref(false)

async function rollWeapon()
{
  try
  {
    const odpowiedz = await fetch("https://localhost:7102/api/Weapons/random");

    if (odpowiedz.ok)
    {
      randomWeapon.value = await odpowiedz.json()
      gameState.value = "deciding"
    }
    else 
    {
      console.error(`Blad serwera: ${odpowiedz.status}`)
    }
  }
  catch(blad)
  {
    console.error(`Błąd: ${blad}`)
  }
}

async function saveResult(won)
{
  try {
    const zapisz = {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ weaponId: randomWeapon.value.id, won: won})
    }

    const odpowiedz = await fetch("https://localhost:7102/api/RollHistory", zapisz);

    if (odpowiedz.ok) {
      gameState.value = "idle"
      randomWeapon.value = null
      await fetchHistory()
      await fetchWeights()
    }
  }
  catch (blad) {
    console.error(`Błąd: ${blad}`)
  }
}

async function fetchHistory()
{
  const odpowiedz = await fetch("https://localhost:7102/api/RollHistory");
  if (odpowiedz.ok) {
    rollHistory.value = await odpowiedz.json()
  }
}

async function fetchWeapons(id)
{
  const odpowiedz = await fetch("https://localhost:7102/api/weapons")

  if (odpowiedz.ok) {
    allWeapons.value = await odpowiedz.json()
  }
}

async function fetchWeights()
{
  const odpowiedz = await fetch("https://localhost:7102/api/weapons/weights")
  if (odpowiedz.ok) {
    weaponWeights.value = await odpowiedz.json()
  }
}

function getWeaponName(id)
{
  const weapon = allWeapons.value.find((wName) => { return wName.id == id })
  return weapon?.name 
}

function getResultText(won)
{
  if (won === true) {
    return "Zwycięstwo"
  }
  else if (won === false) {
    return "Porażka"
  }
  else {
    return "Pominięto"
  }
}

function formatDate(timestamp)
{
  const data = new Date(timestamp)
  const dataStr = data.toLocaleDateString([], { year: 'numeric', month: '2-digit', day: '2-digit'})
  const czasStr = data.toLocaleTimeString([], { hour: "2-digit", minute: "2-digit" });
  return `${dataStr} ${czasStr}`
}

const cyclingName = ref("")
let cycleTimer = null

function startCarousel() {
  cycleTimer = setInterval(() => {
    if (allWeapons.value.length > 0) {
      const randomIndex = Math.floor(Math.random() * allWeapons.value.length)
      cyclingName.value = allWeapons.value[randomIndex].name
    }
  }, 150)
}

onMounted(() => {
  fetchHistory()
  fetchWeapons()
  fetchWeights()
  startCarousel()
})
</script>

<template>
  <div class="app">
    <header class="app_header">
      <h1 class="app_title">ABI Weapon Randomizer</h1>
    </header>

    <section class="roller">
      <div class="weapon-strip">
        <span v-for="w in allWeapons"
          :key="w.id"
          class="weapon-strip_item"
          :class="{ 'weapon-strip_active': randomWeapon && randomWeapon.id === w.id }">
          {{ w.name }}
          <span v-if="showWeight">({{ weaponWeights[w.id]?.toFixed(2) }})</span>
        </span>
      </div>

      <div class="weapon-card" v-if="randomWeapon !== null">
        <h2 class="weapon-card_name">
        {{ randomWeapon.name }}
        <span v-if="showWeight"> ({{ randomWeapon.weight.toFixed(2) }})</span>
        </h2>
        <ul class="weapon-card_attachments">
          <li v-for="attachment in randomWeapon.attachments" :key="attachment.id">
            <span class="slot-label">{{ attachment.slot }}</span>
            <span class="slot-value">{{ attachment.name }}</span>
          </li>
        </ul>
      </div>

      <div class="controls">
        <button class="btn btn-primary" v-if="gameState === 'idle'" @click="rollWeapon">
          Losuj
        </button>

        <div class="controls_decision" v-if="gameState === 'deciding'">
          <button class="btn btn-win" @click="saveResult(true)">Wygrana</button>
          <button class="btn btn-lose" @click="saveResult(false)">Przegrana</button>
          <button class="btn btn-skip" @click="saveResult(null)">Pomiń</button>
        </div>
      </div>
    </section>

    <input type="checkbox" v-model="showWeight" /> Pokazuj wagi losowania
    <hr class="divider" />

    <section class="history" v-if="gameState === 'idle'">
      <h3 class="history_title">Historia</h3>
      <ul class="history_list">
        <li v-for="entry in rollHistory" :key="entry.id" class="history_item">
          <span class="history_weapon">{{ getWeaponName(entry.weaponId) }}</span>
          <span
            class="badge"
            :class="{
              'badge-win': entry.won === true,
              'badge-lose': entry.won === false,
              'badge-skip': entry.won === null
            }"
          >
            {{ getResultText(entry.won) }}
          </span>
          <span class="history_date">{{ formatDate(entry.timestamp) }}</span>
        </li>
      </ul>
    </section>
  </div>
</template>
