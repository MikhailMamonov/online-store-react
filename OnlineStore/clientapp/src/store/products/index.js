import { actions } from "./actions";
import { getters } from "./getters";
import { mutations } from "./mutations";

export default {
  namespaced: true,
  state: () => ({
    products: [],
    categories: [],
  }),
  actions: actions,
  mutations: mutations,
  getters: getters,
};
