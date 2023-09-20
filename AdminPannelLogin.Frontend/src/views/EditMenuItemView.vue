<script setup lang="ts">
const props = defineProps({
  id: Number
});

import { ref } from 'vue';
import type { MenuItem } from '@/api/MenuItem';
import api from '@/api';
const menuItem = ref<MenuItem | undefined>();
api.fetchMenuItemById(props.id!).then((result) => (menuItem.value = result));
</script>
<template>
  <div v-if="menuItem">
    <form action="">
      <p>Deutscher Item Name:</p>
      <input :value="menuItem?.nameDe" type="text" required />

      <p>Englischer Item Name:</p>
      <input :value="menuItem?.nameEn" type="text" />

      <p>Deutsche Beschreibung:</p>
      <input :value="menuItem?.descriptionDe" type="text" />

      <p>Englische Beschreibung:</p>
      <input :value="menuItem?.descriptionEn" type="text" />

      <p>Preis:</p>
      <input :value="menuItem?.price" type="text" required />
      <br />
      <input type="submit" />
    </form>
  </div>
  <div v-else>
    <h1>could not fetch the data</h1>
  </div>
</template>
<style scoped>
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
input[type='text'] {
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
  input[type='text'] {
    font-size: 3vw;
  }
}
</style>
