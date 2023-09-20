<!-- <script setup lang="ts">
const data = {
  price: 'price',
  nameDe: 'TestDe',
  nameEn: 'TestEn',
  descriptionDe: 'desDe',
  descriptionEn: 'desEn'
};

const dataJson = JSON.stringify({ data });
</script> -->
<template>
  <form action="">
    <p>Deutscher Item Name:</p>
    <input type="text" required v-model="form.nameDe" />

    <p>Englischer Item Name:</p>
    <input type="text" v-model="form.nameEn" />

    <p>Deutsche Beschreibung:</p>
    <input type="text" v-model="form.descriptionDe" />

    <p>Englische Beschreibung:</p>
    <input type="text" v-model="form.descriptionEn" />

    <p>Preis:</p>
    <input type="text" required v-model="form.price" />
    <br />
    <button type="submit" @click="submit">submit</button>
  </form>
</template>
<script lang="ts">
export default {
  data() {
    return {
      form: {
        price: '',
        nameDe: '',
        nameEn: '',
        descriptionDe: '',
        descriptionEn: ''
      }
    };
  },
  methods: {
    async submit() {
      fetch('https://localhost:7142/api/menuitems/create', {
        method: 'POST',
        body: JSON.stringify({
          price: 1,
          nameDe: 'Pommes',
          descriptionDe: 'lecker',
          descriptionEn: 'cool'
        }),
        headers: {
          'Content-type': 'application/json; charset=UTF-8'
        }
      });
    }
  }
};
</script>
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
