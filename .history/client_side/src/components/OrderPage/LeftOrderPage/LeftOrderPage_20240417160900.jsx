import { useContext } from "react";
import CardItem from "./CardItem/CardItem";
import { MenuContext } from "../../../context/MenuContext";
import { useSelector } from "react-redux";
import { selectDrinks } from "../../../redux/Reducer/drinkSlice";

const LeftOrderPage = () => {
    const { addSelectedDrink } = useContext(MenuContext);
    const drinks = useSelector(selectDrinks);
    // let arrDrink = [
    //     {
    //         id: 1,
    //         image: "https://mixthatdrink.com/wp-content/uploads/2022/10/sex-on-the-beach-recipe-14-735x1101.jpg",
    //         name: "Tra Oliu",
    //         category: "Tea",
    //         soluong:1,
    //         price: 35000,
    //         ingredients:[
    //             "Tra", "Trai Cay"
    //         ]
    //     },
    //     {
    //         id: 2,
    //         image: "https://mixthatdrink.com/wp-content/uploads/2022/10/sex-on-the-beach-recipe-14-735x1101.jpg",
    //         name: "Tra cherry",
    //         category: "Tea",
    //         price: 45000,
    //         soluong:1,
    //         ingredients:[
    //             "Tra", "Duong"
    //         ]
    //     },
    //     {
    //         id: 3,
    //         image: "https://mixthatdrink.com/wp-content/uploads/2022/10/sex-on-the-beach-recipe-14-735x1101.jpg",
    //         name: "Dau da xay",
    //         category: "Ice",
    //         price: 55000,
    //         soluong:1,
    //         ingredients:[
    //             "Dau", "Duong"
    //         ]
    //     },
    //     {
    //         id: 4,
    //         image: "https://mixthatdrink.com/wp-content/uploads/2022/10/sex-on-the-beach-recipe-14-735x1101.jpg",
    //         name: "Soda chanh",
    //         category: "Soda",
    //         price: 40000,
    //         soluong:1,
    //         ingredients:[
    //             "Soda", "Chanh"
    //         ]
    //     },
    //     {
    //         id: 5,
    //         image: "https://mixthatdrink.com/wp-content/uploads/2022/10/sex-on-the-beach-recipe-14-735x1101.jpg",
    //         name: "Cafe Trung",
    //         category: "Cafe",
    //         soluong:1,
    //         price: 50000,
    //         ingredients:[
    //             "Duong", "Cafe"
    //         ]
    //     }
    // ];

    return (
        <div className="pl-5">
            <div className="font-bold text-xl mb-2 text-[#be9b7b]">Cafe</div>
            <div className="grid grid-cols-auto-fit-100 gap-4 ">
                {drinks.map((item) => (
                    <CardItem key={item.id} id={item.id} items={item} />
                ))}
            </div>
            {/* 
            <div className="font-bold text-xl mb-2 text-[#be9b7b]">Tea</div>
            <div className="grid grid-cols-auto-fit-100 gap-4 ">
                {arrDrink.filter((item) => item.category === "Tea").map((item) => (
                    <CardItem key={item.id} id={item.id} items={item} />
                ))}
            </div>

            <div className="font-bold text-xl mb-2 text-[#be9b7b]">Ice</div>
            <div className="grid grid-cols-auto-fit-100 gap-4 ">
                {arrDrink.filter((item) => item.category === "Ice").map((item) => (
                    <CardItem key={item.id} id={item.id} items={item} />
                ))}
            </div>

            <div className="font-bold text-xl mb-2 text-[#be9b7b]">Soda</div>
            <div className="grid grid-cols-auto-fit-100 gap-4 ">
                {arrDrink.filter((item) => item.category === "Soda").map((item) => (
                    <CardItem key={item.id} id={item.id} items={item} />
                ))}
            </div>

            <div className="font-bold text-xl mb-2 text-[#be9b7b]">Difference</div>
            <div className="grid grid-cols-auto-fit-100 gap-4 ">
                {arrDrink.filter((item) => item.category === "Difference").map((item) => (
                    <CardItem key={item.id} id={item.id} items={item} />
                ))}
            </div> */}
        </div>
    );
};

export default LeftOrderPage;
