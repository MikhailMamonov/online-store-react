<template>
  <v-app>
    <v-card class="overflow-hidden">
      <v-header></v-header>
      <v-main>
        <v-container fluid>
          <router-view />
        </v-container>
      </v-main>
      <v-footer app>
        <!-- -->
      </v-footer>
    </v-card>
  </v-app>
</template>

<script>
// import { mapActions } from "vuex";

import vHeader from "./components/v-header";
export default {
  name: "App",
  components: { vHeader },
  data() {
    return {
      user: null,
    };
  },
  methods: {
    // ...mapActions("products", ["CATEGORIES", "PRODUCTS"]),
    // ...mapActions("users", ["USERS"]),
    login() {},
    async logout() {},
  },
  created() {
    // this.CATEGORIES();
    // this.PRODUCTS();
    // this.USERS();
  },
};
</script>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
