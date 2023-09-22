import { createRouter, createWebHistory } from 'vue-router';
import HomeView from '../views/HomeView.vue';

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView
    },
    {
      path: '/menuItems',
      name: 'menu',
      component: () => import('../views/MenuView.vue')
    },
    {
      path: '/menuItems/:id(\\d+)',
      name: 'menudetail',
      props: true,
      component: () => import('../views/MenuDetailView.vue')
    },
    {
      path: '/menuItems/:id(\\d+)/edit',
      name: 'edit',
      props: true,
      component: () => import('../views/EditMenuItemView.vue')
    },
    {
      path: '/menuItems/create',
      name: 'create',
      component: () => import('../views/CreateMenuItemView.vue')
    },
    {
      path: '/adminLogin',
      name: 'adminLogin',
      component: () => import('../views/AdminLoginView.vue')
    }
  ]
});

export default router;
