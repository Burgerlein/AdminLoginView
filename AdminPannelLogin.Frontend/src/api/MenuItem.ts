export type MenuItem = {
  id: string;
  price: number;
  nameDe: string;
  nameEn: string;
  descriptionDe: string;
  descriptionEn: string;
};
export type MenuItemCreationData = {
  price: number;
  nameDe: string;
  nameEn?: string;
  descriptionDe?: string;
  descriptionEn?: string;
};
export const fetchAllMeuItems = async (): Promise<MenuItem[]> => {
  const json = await fetch('https://localhost:7142/api/menuitems').then((response) =>
    response.json()
  );

  return json as MenuItem[];
};

export const fetchMenuItemById = async (id: number): Promise<MenuItem | undefined> => {
  const json = await fetch('https://localhost:7142/api/menuitems/' + id).then((response) =>
    response.json()
  );
  return json as MenuItem;
};

export const createMenuItem = async (creationData: MenuItemCreationData) => {
  const json = await fetch('https://localhost:7142/api/menuitems/', {
    method: 'POST',
    body: JSON.stringify(creationData),
    headers: {
      'Content-type': 'application/json; charset=UTF-8'
    }
  }).then((response) => response.json());
  return json as MenuItem;
};

export const updateMenuItem = async (updateData: MenuItemCreationData) => {
  const json = await fetch('https://localhost:7142/api/menuitems/', {
    method: 'PUT',
    body: JSON.stringify(updateData),
    headers: {
      'Content-type': 'application/json; charset=UTF-8'
    }
  }).then((response) => response.json());
  return json as MenuItem;
};
