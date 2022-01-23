export const getters = {
  PRODUCTS_BY_CATEGORY: (state) => (categoryId) => {
    debugger;
    return state.products.filter((p) => p.categoryId == categoryId);
  },
};
