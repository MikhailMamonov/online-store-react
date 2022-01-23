export const mutations = {
  SET_USERS(state, users) {
    state.users = users;
  },
  DELETE_USER(state, id) {
    const index = state.users.findIndex((user) => user.id == id);
    state.users.splice(index, 1);
  },

  ADD_USER(state, user) {
    state.users = [...state.users, user];
  },
  EDIT_USER(state, { user, id }) {
    state.users = [...state.users.filter((p) => p.id != id), user];
  },
};
