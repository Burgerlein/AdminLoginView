<script setup lang="ts">
import MenuItemList from '@/components/MenuItemList.vue';
</script>
<template>
  <main>
    <button><a href="/menuItems/create">Create New</a></button>
    <MenuItemList></MenuItemList>
  </main>
</template>
\
<style scoped>
a {
  color: black;
}
</style>
