<template>
  <v-toolbar color="cyan" dark flat>
    <template v-slot:img="{ props }">
      <v-img
        v-bind="props"
        gradient="to top right, rgba(100,115,201,.7), rgba(25,32,72,.7)"
      ></v-img>
    </template>

    <v-app-bar-nav-icon></v-app-bar-nav-icon>

    <v-toolbar-title>Online Shop</v-toolbar-title>

    <v-spacer></v-spacer>

    <v-btn icon>
      <v-icon>mdi-magnify</v-icon>
    </v-btn>

    <v-btn icon>
      <v-icon>mdi-heart</v-icon>
    </v-btn>

    <v-menu bottom left>
      <template v-slot:activator="{ on, attrs }">
        <v-btn icon color="yellow" v-bind="attrs" v-on="on">
          <v-icon>mdi-dots-vertical</v-icon>
        </v-btn>
      </template>

      <v-list>
        <v-list-item v-for="(item, i) in items" :key="i">
          <v-list-item-title>{{ item.title }}</v-list-item-title>
        </v-list-item>
      </v-list>
    </v-menu>

    <template v-slot:extension>
      <v-tabs v-model="currentItem" fixed-tabs slider-color="white">
        <v-tab
          v-for="item in items"
          :key="item.tab"
          :to="item.link"
          :href="'#tab-' + item.tab"
        >
          {{ item.tab }}
        </v-tab>
      </v-tabs>
    </template>
  </v-toolbar>
</template>

<script>
export default {
  name: "v-header",
  components: {},
  data() {
    return {
      currentItem: "tab-Web",
      items: [
        { tab: "Catalog", link: "catalog" },
        { tab: "Admin panel", link: "admin" },
        { tab: "Home", link: "/" },
        { tab: "Login", link: "login" },
      ],
      user: null,
    };
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
