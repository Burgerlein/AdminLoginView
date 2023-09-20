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
      <h1>{{ menuItem?.nameDe }} / {{ menuItem?.nameEn }}</h1>
      <h3>{{ menuItem?.descriptionDe }}</h3>
      <h3>{{ menuItem?.descriptionEn }}</h3>
    </div>
    <div>
      <h2>{{ menuItem?.price }}</h2>
    </div>

    <div>
      <button>Edit BTN</button>
    </div>
  </div>

  <div v-else>
    <h1>could not fetch the data</h1>
  </div>
</template>

<style scoped>
h1 {
  color: white;
}
.menuItemDetailViewContainer {
  display: grid;
  grid-template-columns: auto auto;
}
</style>
