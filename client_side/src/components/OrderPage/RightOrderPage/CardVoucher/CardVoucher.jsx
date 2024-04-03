const CardVoucher=({val})=>{
    return(
        <button role="menuitem"
        class="mb-4 flex w-full cursor-pointer select-none items-center justify-center gap-3 rounded-md px-3 !py-4 pt-[9px] pb-2 text-start leading-tight shadow-md outline-none transition-all hover:bg-blue-gray-50 hover:bg-opacity-80 hover:text-blue-gray-900 focus:bg-blue-gray-50 focus:bg-opacity-80 focus:text-blue-gray-900 active:bg-blue-gray-50 active:bg-opacity-80 active:text-blue-gray-900">
        <img src="https://docs.material-tailwind.com/icons/metamask.svg" alt="metamast" class="w-6 h-6" />
        <div>
        <h6
            class="block font-sans text-sm antialiased font-semibold leading-relaxed tracking-normal uppercase text-blue-gray-900">
            {val.title}
        </h6>
        <h6
            class="block font-sans text-xs antialiased font-medium leading-relaxed tracking-normal uppercase text-blue-gray-900">
            Discount <span>{val.discount}</span> %
        </h6>  </div>      
    </button>
    )
}
export default CardVoucher;