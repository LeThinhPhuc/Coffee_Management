import React from "react";
import { IconButton, Typography } from "@material-tailwind/react";
import { ArrowRightIcon, ArrowLeftIcon } from "@heroicons/react/24/outline";


export function Pagination({ currentPage, totalPages, onPageChange }) {

    const goToNextPage = () => {
        if (currentPage < totalPages) {
            onPageChange(currentPage + 1);
        }
    };

    const goToPrevPage = () => {
        if (currentPage > 1) {
            onPageChange(currentPage - 1);
        }
    };

    return (
        <div className="flex items-center gap-8">
            <IconButton
                size="sm"
                disabled = {currentPage === 1}
                onClick={goToPrevPage}
                variant="outlined">
                <ArrowLeftIcon strokeWidth={2} className="h-4 w-4" />
            </IconButton>

            <Typography color="gray" className="font-normal">
                Page <strong className="text-gray-900">{currentPage}</strong> of{" "}
                <strong className="text-gray-900">{totalPages}</strong>
            </Typography>


            <IconButton
                size="sm"
                disabled = {currentPage >= totalPages }
                onClick={goToNextPage}
                variant="outlined">
                <ArrowRightIcon strokeWidth={2} className="h-4 w-4" />
            </IconButton>
        </div>
    );
}
