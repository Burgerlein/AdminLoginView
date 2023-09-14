<script setup lang="ts">
import { ref } from 'vue';

const username = ref('');
const password = ref('');
</script>
<template>
  <div class="about">
    <form>
      <input placeholder="user name" v-model="username" />
      <br />
      <input placeholder="password" type="password" v-model="password" />
      <br />
      <input type="submit" />
    </form>
  </div>
</template>

<style scoped>
@media (min-width: 1024px) {
  .about {
    min-height: 100vh;
    display: flex;
    align-items: center;
  }
}
</style>
