export type MenuItem = {
  id: string;
  price: string;
  nameDe: string;
  nameEn: string;
  descriptionDe: string;
  descriptionEn: string;
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
