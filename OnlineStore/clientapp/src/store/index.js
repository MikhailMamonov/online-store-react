import Vuex from "vuex";
import Vue from "vue";
import products from "./products/index";
import users from "./users/index";

Vue.use(Vuex);

export const store = new Vuex.Store({
  modules: {
    products,
    users,
  },
});
