import { useContext } from "react";
import CardItem from "./CardItem/CardItem";
import { MenuContext } from "../../../context/MenuContext";

const LeftOrderPage = () => {
  const { addSelectedDrink } = useContext(MenuContext);

  let arrDrink = [
    {
      id: 1,
      image:
        "https://mixthatdrink.com/wp-content/uploads/2022/10/sex-on-the-beach-recipe-14-735x1101.jpg",
      name: "Tra Oliu",
      category: "Tea",
      price: 35000,
    },
    {
      id: 2,
      image:
        "https://mixthatdrink.com/wp-content/uploads/2022/10/sex-on-the-beach-recipe-14-735x1101.jpg",
      name: "Tra cherry",
      category: "Tea",
      price: 45000,
    },
    {
      id: 3,
      image:
        "https://mixthatdrink.com/wp-content/uploads/2022/10/sex-on-the-beach-recipe-14-735x1101.jpg",
      name: "Dau da xay",
      category: "Ice",
      price: 55000,
    },
    {
      id: 4,
      image:
        "https://mixthatdrink.com/wp-content/uploads/2022/10/sex-on-the-beach-recipe-14-735x1101.jpg",
      name: "Soda chanh",
      category: "Soda",
      price: 40000,
    },
    {
      id: 5,
      image:
        "https://mixthatdrink.com/wp-content/uploads/2022/10/sex-on-the-beach-recipe-14-735x1101.jpg",
      name: "Cafe Trung",
      category: "Cafe",
      price: 50000,
    },
  ];

  return (
    <div className="pl-5">
      <div className="font-bold text-xl mb-2 text-[#be9b7b]">Cafe</div>
      <div className="grid grid-cols-auto-fit-100 gap-4 ">
        {arrDrink
          .filter((item) => item.category === "Cafe")
          .map((item) => (
            <CardItem key={item.id} id={item.id} items={item} />
          ))}
      </div>

      <div className="font-bold text-xl mb-2 text-[#be9b7b]">Tea</div>
      <div className="grid grid-cols-auto-fit-100 gap-4 ">
        {arrDrink
          .filter((item) => item.category === "Tea")
          .map((item) => (
            <CardItem key={item.id} id={item.id} items={item} />
          ))}
      </div>

      {drinks.length > 0 &&
        drinks.map((itemd) => (
          <div key={itemd.category}>
            <div className="font-bold text-xl mb-2 text-[#be9b7b]">
              {itemd.category}
            </div>
            <div className="grid grid-cols-auto-fit-100 gap-4 ">
              {itemd.items.map((item) => (
                <CardItem key={item.id} id={item.id} items={item} />
              ))}
            </div>
          </div>
        ))}
    </div>
  );
};

export default LeftOrderPage;
