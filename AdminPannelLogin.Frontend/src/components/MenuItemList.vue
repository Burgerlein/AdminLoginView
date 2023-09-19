<script setup lang="ts">
import { ref } from 'vue';

type MenuItem = {
  id: string;
  price: string;
  nameDe: string;
  nameEn: string;
  descriptionDe: string;
  descriptionEn: string;
};
const menuItems = ref<MenuItem[]>();
fetch('https://localhost:7142/api/menuitems')
  .then((response) => response.json())
  .then((json) => (menuItems.value = json as MenuItem[]));
</script>
<template>
  <main v-if="menuItems">
    <table>
      <tr>
        <th>Id</th>
        <th>Name</th>
        <th>name</th>
        <th>Beschreibung</th>
        <th>description</th>
        <th>Preis</th>
      </tr>
      <tr v-for="menuItem in menuItems" :key="menuItem.id">
        <td>{{ menuItem.id }}</td>
        <td>{{ menuItem.nameDe }}</td>
        <td>{{ menuItem.nameEn }}</td>
        <td>{{ menuItem.descriptionDe }}</td>
        <td>{{ menuItem.descriptionEn }}</td>
        <td>{{ menuItem.price }}</td>
      </tr>
    </table>
  </main>
  <div v-else>
    <h1>could not fetch</h1>
  </div>
</template>
<style scoped>
table {
  width: 100%;
  text-align: center;
}
th {
  color: white;
  font-size: 1vw;
  min-width: 10rem;
}
th,
td {
  border-bottom: 1px solid white;
  border-left: 1px solid white;
}
th:first-of-type,
td:first-of-type {
  border-left: none;
}
table {
  border-collapse: collapse;
}
</style>
