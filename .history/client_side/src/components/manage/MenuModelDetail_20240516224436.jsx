import PropTypes from "prop-types";
import { faTrash } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";

const MenuModelDetail = (props) => {
    return (
        <div className="flex justify-between">
            <p className="inline-block">
                Name: {props.data.item.name} - Quantity: {props.data.quantity}
            </p>
            <p
                className="cursor-pointer size-[20px] text-[#e74c3c] rounded-full hover:scale-125 transition-all"
                onClick={() => {
                    props.handleDeleteIngre(props.data.item);
                }}
            >
                <FontAwesomeIcon icon={faTrash} />
            </p>
        </div>
    );
};

MenuModelDetail.propTypes = {
    data: PropTypes.object,
    handleDeleteIngre: PropTypes.func,
};

export default MenuModelDetail;
