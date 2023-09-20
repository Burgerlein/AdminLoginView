<script setup lang="ts">
import { ref } from 'vue';
import type { MenuItem } from '@/api/MenuItem';
import api from '@/api';

const menuItems = ref<MenuItem[]>();
api.fetchAllMeuItems().then((result) => (menuItems.value = result));
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
        <td>
          <a :href="'menuItems/' + menuItem.id">{{ menuItem.nameDe }}</a>
        </td>
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
