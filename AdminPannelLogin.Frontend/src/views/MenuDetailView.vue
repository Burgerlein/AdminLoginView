<script lang="ts" setup>
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
  <div v-if="menuItem" class="menuItemDetailViewContainer">
    <div>
      <h1 class="green">{{ menuItem?.nameDe }} / {{ menuItem?.nameEn }}</h1>
      <h3>{{ menuItem?.descriptionDe }}</h3>
      <h3>{{ menuItem?.descriptionEn }}</h3>
    </div>
    <div>
      <h2>{{ menuItem?.price }}</h2>
      <a :href="'../edit/' + menuItem.id">Edit BTN</a>
    </div>
  </div>

  <div v-else>
    <h1>could not fetch the data</h1>
  </div>
</template>

<style scoped>
.menuItemDetailViewContainer {
  display: grid;
  grid-template-columns: auto auto;
}
@media (max-width: 1024px) {
  .menuItemDetailViewContainer {
    margin-left: 20%;
    margin-right: 20%;
    margin-top: 15%;
  }
}
</style>
