<template>
  <v-card class="mx-auto">
    <v-navigation-drawer class="deep-purple accent-4" dark permanent>
      <v-list>
        <v-list-item v-for="item in items" :key="item.title" link>
          <v-list-item-icon>
            <v-icon>{{ item.icon }}</v-icon>
          </v-list-item-icon>

          <v-list-item-content>
            <v-list-item-title>{{ item.title }}</v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list>

      <template v-slot:append>
        <div class="pa-2">
          <v-btn block>
            Logout
          </v-btn>
        </div>
      </template>
    </v-navigation-drawer>
  </v-card>
</template>

<script>
export default {
  data() {
    return {
      items: [
        { title: "Home", icon: "mdi-view-dashboard", link: "home" },
        { title: "Catalog", icon: "mdi-forum", link: "catalog" },
        { title: "Admin", link: "admin" },
      ],
      mini: false,
    };
  },
};
</script>
