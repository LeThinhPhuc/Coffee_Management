import { useContext } from "react";
import CardItem from "./CardItem/CardItem";
import { MenuContext } from "../../../context/MenuContext";
import { useSelector } from "react-redux";
import { selectDrinks } from "../../../redux/Reducer/drinkSlice";

const LeftOrderPage = () => {
    const { addSelectedDrink } = useContext(MenuContext);
    const drinks = useSelector(selectDrinks);
    return (
        <div className="pl-5">
            {/* <div className="font-bold text-xl mb-2 text-[#be9b7b]">Cafe</div>
            <div className="grid grid-cols-auto-fit-100 gap-4 ">
                {drinks.map((item) => (
                    <CardItem key={item.id} id={item.id} items={item} />
                ))}
            </div>

            <div className="font-bold text-xl mb-2 text-[#be9b7b]">Cafe</div>
            <div className="grid grid-cols-auto-fit-100 gap-4 ">
                {drinks.map((item) => (
                    <CardItem key={item.id} id={item.id} items={item} />
                ))}
            </div> */}

            {drinks.length > 0 &&
                drinks.map((itemd) => (
                    <div key={itemd.category}>
                        <div className="font-bold text-xl mb-2 text-[#be9b7b]">
                            {itemd.category}
                        </div>
                        <div className="grid grid-cols-auto-fit-100 gap-4 ">
                            {itemd.items.map((item) => (
                                <CardItem
                                    key={item.id}
                                    id={item.id}
                                    items={item}
                                />
                            ))}
                        </div>
                    </div>
                ))}
        </div>
    );
};

export default LeftOrderPage;
