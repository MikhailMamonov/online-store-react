<template>
  <v-container>
    <!-- <v-admin-category :categories="categories"></v-admin-category>

    <v-admin-product :products="products"></v-admin-product>

    <v-admin-user :users="users"></v-admin-user> -->
  </v-container>
</template>

<script>
import { mapState } from "vuex";
// import vAdminCategory from "./v-admin-category.vue";
// import vAdminProduct from "./v-admin-product.vue";
// import vAdminUser from "./v-admin-user.vue";

export default {
  name: "v-admin-panel",
  computed: {
    ...mapState({
      products: (state) => state.products.products,
      users: (state) => state.users.users,
      categories: (state) => state.products.categories,
    }),
  },

  //   components: { vAdminProduct, vAdminCategory, vAdminUser },
};
</script>

<style lang="scss" scoped></style>
