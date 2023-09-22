<script setup lang="ts">
const props = defineProps({
  id: Number
});

import { ref } from 'vue';
import type { MenuItem } from '@/api/MenuItem';
import api from '@/api';

function submit() {
  if (menuItem.value?.nameDe && menuItem.value.price) {
    api.updateMenuItem(menuItem.value);
  }
}

const menuItem = ref<MenuItem | undefined>();
api.fetchMenuItemById(props.id!).then((result) => (menuItem.value = result));
</script>
<template>
  <div v-if="menuItem">
    <form>
      <p>Deutscher Item Name:</p>
      <input type="text" required v-model="menuItem.nameDe" />

      <p>Englischer Item Name:</p>
      <input type="text" v-model="menuItem.nameEn" />

      <p>Deutsche Beschreibung:</p>
      <input type="text" v-model="menuItem.descriptionDe" />

      <p>Englische Beschreibung:</p>
      <input type="text" v-model="menuItem.descriptionEn" />

      <p>Preis:</p>
      <input type="number" required v-model="menuItem.price" />
      <br />
      <input type="submit" @click.capture="submit()" />
    </form>
  </div>
  <div v-else>
    <h1>could not fetch the data</h1>
  </div>
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
