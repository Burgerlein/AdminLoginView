<script setup lang="ts">
import { ref } from 'vue';

type Auto = { name: string; kenzeichen: string };

const auto = ref<Auto>();
fetch('https://localhost:7142/HelloWorld/create')
  .then((response) => response.json())
  .then((json) => (auto.value = json as Auto));
</script>

<template>
  <div class="about">
    <h1>Test {{ auto?.name ?? 'couldnt fetch' }}</h1>
  </div>
</template>
s
<style>
@media (min-width: 1024px) {
  .about {
    min-height: 100vh;
    display: flex;
    align-items: center;
  }
}
</style>
