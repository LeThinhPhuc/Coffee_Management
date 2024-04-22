import { useContext, useEffect, useState } from "react";
import '../../../../App.css'
import { MenuContext } from "../../../../context/MenuContext";
const CardItem = ({ items }) => {
    const [checkTheme, setCheckTheme] = useState(false);
    const { addSelectedDrink, deleteOutSelected, selectedDrink } = useContext(MenuContext);

    const handleClickTheme = () => {
        setCheckTheme(!checkTheme);
        if (!checkTheme)
            addSelectedDrink(items);
        else
            deleteOutSelected(items);
    }

   
    useEffect(()=>{
        let cnt=0;
        for(let i=0;i<selectedDrink.length;i++){
            if(selectedDrink[i].drinkId==items.id){
                cnt++;
            }
        }
        if(cnt==0){
            setCheckTheme(false)
        }
    },[selectedDrink])

    return (
        <div onClick={handleClickTheme} className="relative grid h-[200px] w-full flex-col items-end justify-center overflow-hidden rounded-xl bg-white bg-clip-border text-center text-white-700 transition duration-300 transform hover:scale-105">
        <img src={items.image} className="absolute inset-0 h-full w-full object-cover" alt={items.name} />
        <div className={`absolute inset-0 w-full h-full hover:opacity-[0.15] bg-gradient-to-t ${checkTheme ? 'from-black/100 to-black/0' : 'from-[#dfccaf]/100 via-[#dfccaf]/60 to-[#dfccaf]/0'}`}></div>
        <div className="relative p-6 px-6 py-14 md:px-12">
            <div className="absolute bottom-2 left-0 w-full text-center block mb-4 font-sans text-[vw] antialiased font-bold leading-snug tracking-normal text-[#6f4436] textbase">
                {items.name}
            </div>
            <div className={`absolute bottom-1 left-0 w-full text-[vw] text-center text-[#3c2f2f] textbase ${checkTheme ? '' : 'font-semibold'} ${checkTheme ? 'text-white' : ''}`}>
                {items.price} VND
            </div>
        </div>
    </div>
    );
};

export default CardItem;
