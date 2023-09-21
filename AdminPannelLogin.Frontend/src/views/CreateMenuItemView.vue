<script setup lang="ts">
import api from '@/api';
import type { MenuItemCreationData } from '@/api/MenuItem';
import { ref } from 'vue';

const creationData = ref<MenuItemCreationData>({
  price: 0,
  nameDe: '',
  nameEn: '',
  descriptionDe: '',
  descriptionEn: ''
});

function submit() {
  if (creationData.value.nameDe && creationData.value.price) {
    api.createMenuItem(creationData.value);
  }
}
</script>
<template>
  <form>
    <p>Deutscher Item Name:</p>
    <input type="text" required v-model="creationData.nameDe" />

    <p>Englischer Item Name:</p>
    <input type="text" v-model="creationData.nameEn" />

    <p>Deutsche Beschreibung:</p>
    <input type="text" v-model="creationData.descriptionDe" />

    <p>Englische Beschreibung:</p>
    <input type="text" v-model="creationData.descriptionEn" />

    <p>Preis:</p>
    <input type="number" required v-model="creationData.price" />
    <br />
    <button type="submit" @click.prevent="submit">Senden</button>
  </form>
</template>

<style scoped>
div {
  min-width: 30rem;
}
form {
  display: flex;
  flex-direction: column;
  align-items: center;
  width: 100%;
}
p {
  font-size: 0.8vw;
  margin-top: 10px;
}
input[type='text'],
input[type='number'] {
  background-color: #393c40;
  color: white;
  border: #545c66;
  padding: 6px;
  font-size: 1vw;
  width: 100%;
  text-align: center;
}

@media (max-width: 1024px) {
  p {
    font-size: 2.5vw;
    margin-top: 10px;
  }
  input[type='text'],
  input[type='number'] {
    font-size: 3vw;
  }
}
</style>
