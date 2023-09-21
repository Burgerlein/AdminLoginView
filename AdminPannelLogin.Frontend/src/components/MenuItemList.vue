<script setup lang="ts">
import { ref } from 'vue';
import type { MenuItem } from '@/api/MenuItem';
import api from '@/api';

const menuItems = ref<MenuItem[]>();
api.fetchAllMeuItems().then((result) => (menuItems.value = result));
</script>
<template>
  <div v-if="menuItems">
    <div v-for="(menuItem, index) in menuItems" :key="menuItem.id" class="menuItemList">
      <div class="menuItemListContainer">
        <div>
          <h1>
            <a :href="'menuItems/' + menuItem.id">
              {{ index + 1 }} {{ menuItem.nameDe }}
              {{ menuItem.nameEn ? '/ ' + menuItem.nameEn : '' }}
            </a>
          </h1>
          <h3>{{ menuItem.descriptionDe }}</h3>
          <h3>{{ menuItem.descriptionEn }}</h3>
        </div>
        <h3>{{ menuItem.price }}€</h3>
      </div>
    </div>
  </div>
  <div v-else>
    <h1>Error with fetching data</h1>
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
