export const mutations = {
  SET_PRODUCTS(state, products) {
    state.products = products;
  },
  SET_CATEGORIES(state, categories) {
    state.categories = categories;
  },
  DELETE_PRODUCT(state, id) {
    const index = state.products.findIndex((product) => product.id == id);
    state.products.splice(index, 1);
  },
  DELETE_CATEGORY(state, id) {
    let categories = state.categories.filter((category) => category.id != id);
    state.categories = categories;
  },

  ADD_PRODUCT(state, product) {
    state.products = [...state.products, product];
  },
  ADD_CATEGORY(state, category) {
    let categories = state.categories.concat(category);
    state.categories = categories;
  },
  EDIT_CATEGORY(state, { category, id }) {
    const filter = state.categories.filter((c) => id != c.id);
    console.log(filter);
    state.categories = [
      ...state.categories.filter((c) => id != c.id),
      category,
    ];
  },
  EDIT_PRODUCT(state, { product, id }) {
    state.products = [...state.products.filter((p) => p.id != id), product];
  },
};
