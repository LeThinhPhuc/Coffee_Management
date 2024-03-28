import LeftMenu from "./LeftMenu/LeftMenu";
import RightMenu from "./RightMenu/RightMenu";

const Menu = () => {
    return (
        <div className="grid grid-cols-10 pl-2 pr-2"> 
            <div className="col-span-7">
                <LeftMenu />
            </div>
            <div className="col-span-3">
                <RightMenu />
            </div>
        </div>
    );
}

export default Menu;
