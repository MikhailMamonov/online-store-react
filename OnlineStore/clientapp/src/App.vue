<template>
  <v-app>
    <v-app-bar
      app
      absolute
      color="deep-purple accent-4"
      dense
      dark
      elevation="10"
    >
      <v-app-bar-nav-icon></v-app-bar-nav-icon>

      <v-toolbar-title>Title</v-toolbar-title>

      <v-spacer></v-spacer>

      <v-btn icon>
        <v-icon>mdi-magnify</v-icon>
      </v-btn>

      <v-btn icon>
        <v-icon>mdi-heart</v-icon>
      </v-btn>

      <v-btn icon>
        <v-icon>mdi-dots-vertical</v-icon>
      </v-btn>
    </v-app-bar>
    <v-main>
      <v-container>
        <v-row>
          <v-col><v-navbar></v-navbar></v-col>
          <v-col><router-view /></v-col>
        </v-row>
      </v-container>
    </v-main>
    <v-footer app>
      <!-- -->
    </v-footer>
  </v-app>
</template>

<script>
import vNavbar from "./components/v-navbar.vue";
export default {
  name: "App",
  components: { vNavbar },
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
}
</style>
