<template>
  <v-container class="bv-example-row">
    <!-- <v-catalog-marketing> </v-catalog-marketing> -->
    <h3>All Products</h3>
    <v-row>
      <v-col>
        All Products
      </v-col>
    </v-row>
    <h3>Best Products</h3>
    <v-row>
      <v-col>
        Filtered Products
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
// import vCatalogMarketing from "./v-catalog-marketing.vue";
import { mapGetters } from "vuex";

export default {
  name: "v-catalog",
  props: {
    categoryId: {
      type: String,
      default: null,
    },
  },

  computed: {
    ...mapGetters({ productsByCategory: "products/PRODUCTS_BY_CATEGORY" }),
    filteredProducts() {
      debugger;
      let products = this.productsByCategory(this.categoryId);
      return products;
    },
  },
  methods: {},
};
</script>

<style lang="scss" scoped></style>
