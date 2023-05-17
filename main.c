/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
  ******************************************************************************
  * @attention
  *
  * Copyright (c) 2023 STMicroelectronics.
  * All rights reserved.
  *
  * This software is licensed under terms that can be found in the LICENSE file
  * in the root directory of this software component.
  * If no LICENSE file comes with this software, it is provided AS-IS.
  *
  ******************************************************************************
  */
/* USER CODE END Header */
/* Includes ------------------------------------------------------------------*/
#include "main.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
uint8_t data;
uint8_t dieukien=0;
uint8_t number_reg = 0;

//Range of data modbus
uint8_t RxData[256];
uint8_t TxData[256];

#define ILLEGAL_FUNCTION 	   0x01 
#define ILLEGAL_DATA_ADDRESS 0x02 
#define ILLEGAL_DATA_VALUE   0x03 

//CRC Data
uint8_t CRC_byte[2];


//Library of modbus
#define SLAVE_ID 5

static uint16_t Holding_Registers_Database[50]=
{
		0x0008,  0x0009,  0x0000,  0x0000,  0x0000,  5555,  6666,  7777,  8888,  9999,   // 0-9   40001-40010
		12345, 15432, 15535, 10234, 19876, 13579, 10293, 19827, 13456, 14567,  // 10-19 40011-40020
		21345, 22345, 24567, 25678, 26789, 24680, 20394, 29384, 26937, 27654,  // 20-29 40021-40030
		31245, 31456, 34567, 35678, 36789, 37890, 30948, 34958, 35867, 36092,  // 30-39 40031-40040
		45678, 46789, 47890, 41235, 42356, 43567, 40596, 49586, 48765, 41029,  // 40-49 40041-40050
};

/* Table of CRC values for high-order byte */
static const uint8_t table_crc_hi[] = 
	{
    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
    0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
    0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0,
    0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1,
    0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41,
    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1,
    0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
    0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40,
    0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1,
    0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
    0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40,
    0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0,
    0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40,
    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
    0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
    0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0,
    0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
    0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0,
    0x80, 0x41, 0x00, 0xC1, 0x81, 0x40, 0x00, 0xC1, 0x81, 0x40,
    0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0, 0x80, 0x41, 0x00, 0xC1,
    0x81, 0x40, 0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41,
    0x00, 0xC1, 0x81, 0x40, 0x01, 0xC0, 0x80, 0x41, 0x01, 0xC0,
    0x80, 0x41, 0x00, 0xC1, 0x81, 0x40
	};

/* Table of CRC values for low-order byte */
static const uint8_t table_crc_lo[] = 
	{
    0x00, 0xC0, 0xC1, 0x01, 0xC3, 0x03, 0x02, 0xC2, 0xC6, 0x06,
    0x07, 0xC7, 0x05, 0xC5, 0xC4, 0x04, 0xCC, 0x0C, 0x0D, 0xCD,
    0x0F, 0xCF, 0xCE, 0x0E, 0x0A, 0xCA, 0xCB, 0x0B, 0xC9, 0x09,
    0x08, 0xC8, 0xD8, 0x18, 0x19, 0xD9, 0x1B, 0xDB, 0xDA, 0x1A,
    0x1E, 0xDE, 0xDF, 0x1F, 0xDD, 0x1D, 0x1C, 0xDC, 0x14, 0xD4,
    0xD5, 0x15, 0xD7, 0x17, 0x16, 0xD6, 0xD2, 0x12, 0x13, 0xD3,
    0x11, 0xD1, 0xD0, 0x10, 0xF0, 0x30, 0x31, 0xF1, 0x33, 0xF3,
    0xF2, 0x32, 0x36, 0xF6, 0xF7, 0x37, 0xF5, 0x35, 0x34, 0xF4,
    0x3C, 0xFC, 0xFD, 0x3D, 0xFF, 0x3F, 0x3E, 0xFE, 0xFA, 0x3A,
    0x3B, 0xFB, 0x39, 0xF9, 0xF8, 0x38, 0x28, 0xE8, 0xE9, 0x29,
    0xEB, 0x2B, 0x2A, 0xEA, 0xEE, 0x2E, 0x2F, 0xEF, 0x2D, 0xED,
    0xEC, 0x2C, 0xE4, 0x24, 0x25, 0xE5, 0x27, 0xE7, 0xE6, 0x26,
    0x22, 0xE2, 0xE3, 0x23, 0xE1, 0x21, 0x20, 0xE0, 0xA0, 0x60,
    0x61, 0xA1, 0x63, 0xA3, 0xA2, 0x62, 0x66, 0xA6, 0xA7, 0x67,
    0xA5, 0x65, 0x64, 0xA4, 0x6C, 0xAC, 0xAD, 0x6D, 0xAF, 0x6F,
    0x6E, 0xAE, 0xAA, 0x6A, 0x6B, 0xAB, 0x69, 0xA9, 0xA8, 0x68,
    0x78, 0xB8, 0xB9, 0x79, 0xBB, 0x7B, 0x7A, 0xBA, 0xBE, 0x7E,
    0x7F, 0xBF, 0x7D, 0xBD, 0xBC, 0x7C, 0xB4, 0x74, 0x75, 0xB5,
    0x77, 0xB7, 0xB6, 0x76, 0x72, 0xB2, 0xB3, 0x73, 0xB1, 0x71,
    0x70, 0xB0, 0x50, 0x90, 0x91, 0x51, 0x93, 0x53, 0x52, 0x92,
    0x96, 0x56, 0x57, 0x97, 0x55, 0x95, 0x94, 0x54, 0x9C, 0x5C,
    0x5D, 0x9D, 0x5F, 0x9F, 0x9E, 0x5E, 0x5A, 0x9A, 0x9B, 0x5B,
    0x99, 0x59, 0x58, 0x98, 0x88, 0x48, 0x49, 0x89, 0x4B, 0x8B,
    0x8A, 0x4A, 0x4E, 0x8E, 0x8F, 0x4F, 0x8D, 0x4D, 0x4C, 0x8C,
    0x44, 0x84, 0x85, 0x45, 0x87, 0x47, 0x46, 0x86, 0x82, 0x42,
    0x43, 0x83, 0x41, 0x81, 0x80, 0x40
};



/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */
void UART2_SendChar (uint8_t c);
void UART2_SendString (char *string);
uint8_t UART2_GetChar();


void modbusException(uint8_t exceptioncode);
uint8_t Read_Holding_Data(void);
uint8_t Write_Holding_Data(void);

uint16_t crc16(uint8_t *buffer, uint16_t buffer_length);
void Combine_Go_Data(uint8_t message[], int size);
void MODBUS();

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */
/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/

/* USER CODE BEGIN PV */

/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */

/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  * @retval int
  */
int main(void)
{
  /* USER CODE BEGIN 1 */

  /* USER CODE END 1 */

  /* MCU Configuration--------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  HAL_Init();

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();

  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  /* USER CODE BEGIN 2 */

	//UART in STM32
	
	//1.Enable the UART Clock and GPIO Clock
	RCC->APB1ENR |= (1<<17); //Enable clock Uart2 voi chan PA2 chan TX va PA3 chan RX
	RCC->AHB1ENR |= (1<<0);  //Enable clock chan A cu the A2 va A3
	
	//Configuration the uart pin PA2 va PA3
	GPIOA->MODER |= (2<<2*2);
	GPIOA->MODER |= (2<<2*3);  //Set up PA2 va PA3 la alter
	GPIOA->OSPEEDR |= (3<<2*2) | (3<<2*3); //Set up toc do cao
	
	//Tra hinh 26 tim loai AFRL hay AFRH vi 2,3 thuoc 0 den 7 nen chon AFRL
	GPIOA->AFR[0] |= (7<<4*2); 
	GPIOA->AFR[0] |= (7<<4*3);
	
	//Enable UART
	USART2->CR1 = 0x00;  //Clear all
	USART2->CR1 |= (1<<13); //UE..Enable
	
	//Length bit
	USART2->CR1 &= ~(1<<12);  //	1 start bit, 8 data bit
	
	//Lua chon baudrate
	USART2->BRR = (3<<0) | (104<<4); //16MHz baud rate = 9600
	
	//Enable the transmitter/receiver by setting TE and RE bit in USART_CR1 
	USART2->CR1 |= (1<<2); // RE=1 Enable Receiver 
	USART2->CR1 |= (1<<3); // TE=1 Enable Transmitter
  
	USART2->CR1 |= (1<<5);
	NVIC->ISER[1] =(1<<6);   // Interupt and event (enable UART2 interupt)
	
  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
  }
  /* USER CODE END 3 */
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};

  /** Initializes the RCC Oscillators according to the specified parameters
  * in the RCC_OscInitTypeDef structure.
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSI;
  RCC_OscInitStruct.HSIState = RCC_HSI_ON;
  RCC_OscInitStruct.HSICalibrationValue = RCC_HSICALIBRATION_DEFAULT;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_NONE;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }

  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_HSI;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV1;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV1;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_0) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief GPIO Initialization Function
  * @param None
  * @retval None
  */
static void MX_GPIO_Init(void)
{

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOA_CLK_ENABLE();

}

/* USER CODE BEGIN 4 */

uint16_t crc16(uint8_t *buffer, uint16_t buffer_length)
{
    uint8_t crc_hi = 0xFF; /* high CRC byte initialized */
    uint8_t crc_lo = 0xFF; /* low CRC byte initialized */
    unsigned int i; /* will index into CRC lookup */

    /* pass through message buffer */
    while (buffer_length--) {
        i = crc_lo ^ *buffer++; /* calculate the CRC  */
        crc_lo = crc_hi ^ table_crc_hi[i];
        crc_hi = table_crc_lo[i];
    }

    return (crc_hi << 8 | crc_lo);
}

void UART2_SendChar (uint8_t c)
{
	USART2->DR = c; //Gui vao data vao thanh DR
	while(!(USART2->SR & (1<<6))); //wait TC duoc set . tho khi do da duoc truyen xong
}

void UART2_SendString (char *string)
{
	while(*string) UART2_SendChar(*string++);
}

//Ham UART nhan ve
uint8_t UART2_GetChar()
{
	char temp;
	
	while(!(USART2->SR & (1<<5))); //cho khi RXNE duoc set
	temp = USART2->DR;    //dOC DATA
	return temp;
}

void Combine_Go_Data(uint8_t message[], int size)
	{
		message[size]   = crc16(message,size);
		message[size+1] = crc16(message,size)>>8;
		for(uint8_t i =0 ; i<size+2; i++)
		{
			UART2_SendChar(message[i]);
		}
	}


void modbusException(uint8_t exceptioncode) 
{
		TxData[0] = RxData[0] ; // Slave ID 
		TxData[1] = RxData[1]|0x80 ; // adding 1 to the MSB  of the function code 
		TxData[2] = exceptioncode ; // Load the Exception code 
		Combine_Go_Data(TxData,3) ; 		
}


uint8_t Read_Holding_Data(void) 
{
	uint16_t startAddr = ((RxData[2]<<8)|RxData[3]);  // start Register Address 
	uint16_t numRegs = 	 ((RxData[4]<<8)|RxData[5]);  // number to registers master has requested  
	
	if ((numRegs<1)||(numRegs>125)) // maximum no. of Registers as per the PDF
	{
		modbusException(ILLEGAL_DATA_VALUE) ; //send the exception 
		return 0 ; 
	}
	
	uint16_t endAdrr = startAddr+numRegs-1 ;// end Register 
	
	if(endAdrr>49) 
	{
		// end Register can not be more than 49 as we only have record of 50 register 
		modbusException(ILLEGAL_DATA_ADDRESS); 
		return 0 ;
	}
	
	// prepare TxData buffer 
	TxData[0] = SLAVE_ID ; // Slave ID 
	TxData[1] = RxData[1] ; // adding 1 to the MSB  of the function code 
	TxData[2] = numRegs*2 ; // Load the Exception code 
		
	int indx = 3 ; // We need to keep the track of how many bytes has been stored in TxData Buffer    		
	for (int i=0; i<numRegs; i++)   // Load the actual data into TxData buffer
	{
		TxData[indx++] = (Holding_Registers_Database[startAddr]>>8)&0xFF;  // extract the higher byte
		TxData[indx++] = (Holding_Registers_Database[startAddr])&0xFF;   // extract the lower byte
		startAddr++;  // increment the register address
	}
	
	Combine_Go_Data(TxData,indx);
	
	return 1;   // success
}

uint8_t Write_Holding_Data(void)
{
	uint16_t startAddr = ((RxData[2]<<8)|RxData[3]);  // start Register Address 
	uint16_t numRegs = 	 ((RxData[4]<<8)|RxData[5]);  // number to registers master has requested  
	
	if ((numRegs<1)||(numRegs>123)) // maximum no. of Registers as per the PDF
	{
		modbusException(ILLEGAL_DATA_VALUE) ; //send the exception 
		return 0 ; 
	}
	
	uint16_t endAdrr = startAddr+numRegs-1 ;// end Register 
	
	if(endAdrr>49) 
	{
		// end Register can not be more than 49 as we only have record of 50 register 
		modbusException(ILLEGAL_DATA_ADDRESS); 
		return 0 ;
	}
	
	int ind_y = 7;  // we need to keep track of index in RxData
	for (int i=0; i<numRegs; i++)
	{
		Holding_Registers_Database[startAddr++] = (RxData[ind_y++]<<8)|RxData[ind_y+1];
		ind_y++; 
	}

	// Prepare Response

	//| SLAVE_ID | FUNCTION_CODE | Start Addr | num of Regs    | CRC     |
	//| 1 BYTE   |  1 BYTE       |  2 BYTE    | 2 BYTES      | 2 BYTES |

	TxData[0] = SLAVE_ID;    // slave ID
	TxData[1] = RxData[1];   // function code
	TxData[2] = RxData[2];   // Start Addr HIGH Byte
	TxData[3] = RxData[3];   // Start Addr LOW Byte
	TxData[4] = RxData[4];   // num of Regs HIGH Byte
	TxData[5] = RxData[5];   // num of Regs LOW Byte

	Combine_Go_Data(TxData,6);  
	return 1;   // success
}

void MODBUS()
{
	if(RxData[0] == SLAVE_ID)
	{
		switch (RxData[1])
		{
			case 0x03 :
					if(number_reg==8)
					{
						Read_Holding_Data();
						number_reg=0;
					}
			break;
					
			case 0x10 :
					if((RxData[6]!=0)&&(number_reg==(RxData[6]+9)))
					{
						Write_Holding_Data();
						number_reg=0;
					}
			break; 

			default: 
				break;
		}
	}
}

void USART2_IRQHandler(void)
{
		if((USART2->SR & (1<<5)))
		{
			RxData[number_reg] = UART2_GetChar();
			number_reg++;
			MODBUS();
		}
}
/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  __disable_irq();
  while (1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */
