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
* {
  -webkit-user-select: none; /* Safari */
  -ms-user-select: none; /* IE 10 and IE 11 */
  user-select: none; /* Standard syntax */
}
.menuItemListContainer {
  display: grid;
  grid-template-columns: 80% 20%;
}
.menuItemList {
  margin-top: 30px;
  margin-bottom: 30px;
}
</style>
