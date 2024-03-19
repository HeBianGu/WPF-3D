using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageMathematics
	/// </summary>
	/// <remarks>
	///    Add, subtract, multiply, divide, invert, sin,
	/// cos, exp, log.
	///
	/// vtkImageMathematics implements basic mathematic operations SetOperation is
	/// used to select the filters behavior.  The filter can take two or one
	/// input.
	/// </remarks>
	// Token: 0x02000258 RID: 600
	public class vtkImageMathematics : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006EB8 RID: 28344 RVA: 0x0009FAC5 File Offset: 0x0009DCC5
		static vtkImageMathematics()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMathematics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMathematics"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006EB9 RID: 28345 RVA: 0x0009FAED File Offset: 0x0009DCED
		public vtkImageMathematics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006EBA RID: 28346
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMathematics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006EBB RID: 28347 RVA: 0x0009FAFC File Offset: 0x0009DCFC
		public new static vtkImageMathematics New()
		{
			vtkImageMathematics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMathematics.vtkImageMathematics_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMathematics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006EBC RID: 28348 RVA: 0x0009FB50 File Offset: 0x0009DD50
		public vtkImageMathematics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageMathematics.vtkImageMathematics_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006EBD RID: 28349 RVA: 0x0009FB94 File Offset: 0x0009DD94
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006EBE RID: 28350
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_DivideByZeroToCOff_01(HandleRef pThis);

		/// <summary>
		/// How to handle divide by zero. Default is 0.
		/// </summary>
		// Token: 0x06006EBF RID: 28351 RVA: 0x0009FB9F File Offset: 0x0009DD9F
		public virtual void DivideByZeroToCOff()
		{
			vtkImageMathematics.vtkImageMathematics_DivideByZeroToCOff_01(base.GetCppThis());
		}

		// Token: 0x06006EC0 RID: 28352
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_DivideByZeroToCOn_02(HandleRef pThis);

		/// <summary>
		/// How to handle divide by zero. Default is 0.
		/// </summary>
		// Token: 0x06006EC1 RID: 28353 RVA: 0x0009FBAE File Offset: 0x0009DDAE
		public virtual void DivideByZeroToCOn()
		{
			vtkImageMathematics.vtkImageMathematics_DivideByZeroToCOn_02(base.GetCppThis());
		}

		// Token: 0x06006EC2 RID: 28354
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageMathematics_GetConstantC_03(HandleRef pThis);

		/// <summary>
		/// A constant used by some operations (typically additive). Default is 0.
		/// </summary>
		// Token: 0x06006EC3 RID: 28355 RVA: 0x0009FBC0 File Offset: 0x0009DDC0
		public virtual double GetConstantC()
		{
			return vtkImageMathematics.vtkImageMathematics_GetConstantC_03(base.GetCppThis());
		}

		// Token: 0x06006EC4 RID: 28356
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageMathematics_GetConstantK_04(HandleRef pThis);

		/// <summary>
		/// A constant used by some operations (typically multiplicative). Default is 1.
		/// </summary>
		// Token: 0x06006EC5 RID: 28357 RVA: 0x0009FBE0 File Offset: 0x0009DDE0
		public virtual double GetConstantK()
		{
			return vtkImageMathematics.vtkImageMathematics_GetConstantK_04(base.GetCppThis());
		}

		// Token: 0x06006EC6 RID: 28358
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMathematics_GetDivideByZeroToC_05(HandleRef pThis);

		/// <summary>
		/// How to handle divide by zero. Default is 0.
		/// </summary>
		// Token: 0x06006EC7 RID: 28359 RVA: 0x0009FC00 File Offset: 0x0009DE00
		public virtual int GetDivideByZeroToC()
		{
			return vtkImageMathematics.vtkImageMathematics_GetDivideByZeroToC_05(base.GetCppThis());
		}

		// Token: 0x06006EC8 RID: 28360
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMathematics_GetInput_06(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one input to this filter. This method is only for support of
		/// old-style pipeline connections.  When writing new code you should
		/// use vtkAlgorithm::GetInputConnection(0, num).
		/// </summary>
		// Token: 0x06006EC9 RID: 28361 RVA: 0x0009FC20 File Offset: 0x0009DE20
		public new vtkDataObject GetInput(int idx)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMathematics.vtkImageMathematics_GetInput_06(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06006ECA RID: 28362
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMathematics_GetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one input to this filter. This method is only for support of
		/// old-style pipeline connections.  When writing new code you should
		/// use vtkAlgorithm::GetInputConnection(0, num).
		/// </summary>
		// Token: 0x06006ECB RID: 28363 RVA: 0x0009FC90 File Offset: 0x0009DE90
		public new vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMathematics.vtkImageMathematics_GetInput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06006ECC RID: 28364
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMathematics_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006ECD RID: 28365 RVA: 0x0009FD00 File Offset: 0x0009DF00
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageMathematics.vtkImageMathematics_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06006ECE RID: 28366
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMathematics_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006ECF RID: 28367 RVA: 0x0009FD20 File Offset: 0x0009DF20
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageMathematics.vtkImageMathematics_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06006ED0 RID: 28368
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMathematics_GetNumberOfInputs_10(HandleRef pThis);

		/// <summary>
		/// Get the number of inputs to this filter. This method is only for
		/// support of old-style pipeline connections.  When writing new code
		/// you should use vtkAlgorithm::GetNumberOfInputConnections(0).
		/// </summary>
		// Token: 0x06006ED1 RID: 28369 RVA: 0x0009FD3C File Offset: 0x0009DF3C
		public int GetNumberOfInputs()
		{
			return vtkImageMathematics.vtkImageMathematics_GetNumberOfInputs_10(base.GetCppThis());
		}

		// Token: 0x06006ED2 RID: 28370
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMathematics_GetOperation_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the Operation to perform.
		/// </summary>
		// Token: 0x06006ED3 RID: 28371 RVA: 0x0009FD5C File Offset: 0x0009DF5C
		public virtual int GetOperation()
		{
			return vtkImageMathematics.vtkImageMathematics_GetOperation_11(base.GetCppThis());
		}

		// Token: 0x06006ED4 RID: 28372
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMathematics_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006ED5 RID: 28373 RVA: 0x0009FD7C File Offset: 0x0009DF7C
		public override int IsA(string type)
		{
			return vtkImageMathematics.vtkImageMathematics_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06006ED6 RID: 28374
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMathematics_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006ED7 RID: 28375 RVA: 0x0009FD9C File Offset: 0x0009DF9C
		public new static int IsTypeOf(string type)
		{
			return vtkImageMathematics.vtkImageMathematics_IsTypeOf_13(type);
		}

		// Token: 0x06006ED8 RID: 28376
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMathematics_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006ED9 RID: 28377 RVA: 0x0009FDB8 File Offset: 0x0009DFB8
		public new vtkImageMathematics NewInstance()
		{
			vtkImageMathematics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMathematics.vtkImageMathematics_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMathematics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006EDA RID: 28378
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_ReplaceNthInputConnection_16(HandleRef pThis, int idx, HandleRef input);

		/// <summary>
		/// Replace one of the input connections with a new input.  You can
		/// only replace input connections that you previously created with
		/// AddInputConnection() or, in the case of the first input,
		/// with SetInputConnection().
		/// </summary>
		// Token: 0x06006EDB RID: 28379 RVA: 0x0009FE14 File Offset: 0x0009E014
		public virtual void ReplaceNthInputConnection(int idx, vtkAlgorithmOutput input)
		{
			vtkImageMathematics.vtkImageMathematics_ReplaceNthInputConnection_16(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06006EDC RID: 28380
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMathematics_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006EDD RID: 28381 RVA: 0x0009FE44 File Offset: 0x0009E044
		public new static vtkImageMathematics SafeDownCast(vtkObjectBase o)
		{
			vtkImageMathematics vtkImageMathematics = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMathematics.vtkImageMathematics_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMathematics = (vtkImageMathematics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMathematics.Register(null);
				}
			}
			return vtkImageMathematics;
		}

		// Token: 0x06006EDE RID: 28382
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetConstantC_18(HandleRef pThis, double _arg);

		/// <summary>
		/// A constant used by some operations (typically additive). Default is 0.
		/// </summary>
		// Token: 0x06006EDF RID: 28383 RVA: 0x0009FEC3 File Offset: 0x0009E0C3
		public virtual void SetConstantC(double _arg)
		{
			vtkImageMathematics.vtkImageMathematics_SetConstantC_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06006EE0 RID: 28384
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetConstantK_19(HandleRef pThis, double _arg);

		/// <summary>
		/// A constant used by some operations (typically multiplicative). Default is 1.
		/// </summary>
		// Token: 0x06006EE1 RID: 28385 RVA: 0x0009FED3 File Offset: 0x0009E0D3
		public virtual void SetConstantK(double _arg)
		{
			vtkImageMathematics.vtkImageMathematics_SetConstantK_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06006EE2 RID: 28386
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetDivideByZeroToC_20(HandleRef pThis, int _arg);

		/// <summary>
		/// How to handle divide by zero. Default is 0.
		/// </summary>
		// Token: 0x06006EE3 RID: 28387 RVA: 0x0009FEE3 File Offset: 0x0009E0E3
		public virtual void SetDivideByZeroToC(int _arg)
		{
			vtkImageMathematics.vtkImageMathematics_SetDivideByZeroToC_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06006EE4 RID: 28388
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetInput1Data_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the inputs to this filter. For some operations, the second input
		/// is not used.
		/// </summary>
		// Token: 0x06006EE5 RID: 28389 RVA: 0x0009FEF4 File Offset: 0x0009E0F4
		public virtual void SetInput1Data(vtkDataObject arg0)
		{
			vtkImageMathematics.vtkImageMathematics_SetInput1Data_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06006EE6 RID: 28390
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetInput2Data_22(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the inputs to this filter. For some operations, the second input
		/// is not used.
		/// </summary>
		// Token: 0x06006EE7 RID: 28391 RVA: 0x0009FF24 File Offset: 0x0009E124
		public virtual void SetInput2Data(vtkDataObject arg0)
		{
			vtkImageMathematics.vtkImageMathematics_SetInput2Data_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06006EE8 RID: 28392
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetInputConnection_23(HandleRef pThis, int idx, HandleRef input);

		/// <summary>
		/// Set the inputs to this filter. For some operations, the second input
		/// is not used.
		/// </summary>
		// Token: 0x06006EE9 RID: 28393 RVA: 0x0009FF54 File Offset: 0x0009E154
		public override void SetInputConnection(int idx, vtkAlgorithmOutput input)
		{
			vtkImageMathematics.vtkImageMathematics_SetInputConnection_23(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06006EEA RID: 28394
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetInputConnection_24(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the inputs to this filter. For some operations, the second input
		/// is not used.
		/// </summary>
		// Token: 0x06006EEB RID: 28395 RVA: 0x0009FF84 File Offset: 0x0009E184
		public override void SetInputConnection(vtkAlgorithmOutput input)
		{
			vtkImageMathematics.vtkImageMathematics_SetInputConnection_24(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06006EEC RID: 28396
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetInputData_25(HandleRef pThis, int idx, HandleRef input);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06006EED RID: 28397 RVA: 0x0009FFB4 File Offset: 0x0009E1B4
		public new void SetInputData(int idx, vtkDataObject input)
		{
			vtkImageMathematics.vtkImageMathematics_SetInputData_25(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06006EEE RID: 28398
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetInputData_26(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06006EEF RID: 28399 RVA: 0x0009FFE4 File Offset: 0x0009E1E4
		public new void SetInputData(vtkDataObject input)
		{
			vtkImageMathematics.vtkImageMathematics_SetInputData_26(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06006EF0 RID: 28400
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperation_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the Operation to perform.
		/// </summary>
		// Token: 0x06006EF1 RID: 28401 RVA: 0x000A0013 File Offset: 0x0009E213
		public virtual void SetOperation(int _arg)
		{
			vtkImageMathematics.vtkImageMathematics_SetOperation_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06006EF2 RID: 28402
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToATAN_28(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the arctangent of the corresponding pixel
		/// in Input1. Input2 is not used.
		/// </summary>
		// Token: 0x06006EF3 RID: 28403 RVA: 0x000A0023 File Offset: 0x0009E223
		public void SetOperationToATAN()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToATAN_28(base.GetCppThis());
		}

		// Token: 0x06006EF4 RID: 28404
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToATAN2_29(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the arctangent of the corresponding pixel
		/// in Input1. Input2 is not used.
		/// </summary>
		// Token: 0x06006EF5 RID: 28405 RVA: 0x000A0032 File Offset: 0x0009E232
		public void SetOperationToATAN2()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToATAN2_29(base.GetCppThis());
		}

		// Token: 0x06006EF6 RID: 28406
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToAbsoluteValue_30(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the absolute value of the corresponding pixel
		/// in Input1. Input2 is not used.
		/// </summary>
		// Token: 0x06006EF7 RID: 28407 RVA: 0x000A0041 File Offset: 0x0009E241
		public void SetOperationToAbsoluteValue()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToAbsoluteValue_30(base.GetCppThis());
		}

		// Token: 0x06006EF8 RID: 28408
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToAdd_31(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the sum of the corresponding pixels
		/// in Input1 and Input2.
		/// </summary>
		// Token: 0x06006EF9 RID: 28409 RVA: 0x000A0050 File Offset: 0x0009E250
		public void SetOperationToAdd()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToAdd_31(base.GetCppThis());
		}

		// Token: 0x06006EFA RID: 28410
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToAddConstant_32(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the product of ConstantC with the
		/// corresponding pixel in Input1. Input2 is not used.
		/// </summary>
		// Token: 0x06006EFB RID: 28411 RVA: 0x000A005F File Offset: 0x0009E25F
		public void SetOperationToAddConstant()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToAddConstant_32(base.GetCppThis());
		}

		// Token: 0x06006EFC RID: 28412
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToComplexMultiply_33(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the quotient of the corresponding pixels
		/// in Input1 and Input2 (Output = Input1 / Input2).
		/// </summary>
		// Token: 0x06006EFD RID: 28413 RVA: 0x000A006E File Offset: 0x0009E26E
		public void SetOperationToComplexMultiply()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToComplexMultiply_33(base.GetCppThis());
		}

		// Token: 0x06006EFE RID: 28414
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToConjugate_34(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the quotient of the corresponding pixels
		/// in Input1 and Input2 (Output = Input1 / Input2).
		/// </summary>
		// Token: 0x06006EFF RID: 28415 RVA: 0x000A007D File Offset: 0x0009E27D
		public void SetOperationToConjugate()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToConjugate_34(base.GetCppThis());
		}

		// Token: 0x06006F00 RID: 28416
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToCos_35(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the cosine of the corresponding pixel
		/// in Input1. Input2 is not used.
		/// </summary>
		// Token: 0x06006F01 RID: 28417 RVA: 0x000A008C File Offset: 0x0009E28C
		public void SetOperationToCos()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToCos_35(base.GetCppThis());
		}

		// Token: 0x06006F02 RID: 28418
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToDivide_36(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the quotient of the corresponding pixels
		/// in Input1 and Input2 (Output = Input1 / Input2).
		/// </summary>
		// Token: 0x06006F03 RID: 28419 RVA: 0x000A009B File Offset: 0x0009E29B
		public void SetOperationToDivide()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToDivide_36(base.GetCppThis());
		}

		// Token: 0x06006F04 RID: 28420
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToExp_37(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the exponential of the corresponding pixel
		/// in Input1. Input2 is not used.
		/// </summary>
		// Token: 0x06006F05 RID: 28421 RVA: 0x000A00AA File Offset: 0x0009E2AA
		public void SetOperationToExp()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToExp_37(base.GetCppThis());
		}

		// Token: 0x06006F06 RID: 28422
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToInvert_38(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to 1 over the corresponding pixel
		/// in Input1 and Input2 (output = 1 / Input1). Input2 is not used.
		/// </summary>
		// Token: 0x06006F07 RID: 28423 RVA: 0x000A00B9 File Offset: 0x0009E2B9
		public void SetOperationToInvert()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToInvert_38(base.GetCppThis());
		}

		// Token: 0x06006F08 RID: 28424
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToLog_39(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the log of the corresponding pixel
		/// in Input1. Input2 is not used.
		/// </summary>
		// Token: 0x06006F09 RID: 28425 RVA: 0x000A00C8 File Offset: 0x0009E2C8
		public void SetOperationToLog()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToLog_39(base.GetCppThis());
		}

		// Token: 0x06006F0A RID: 28426
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToMax_40(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the maximum of the corresponding pixels
		/// in Input1 and Input2. (Output = max(Input1, Input2))
		/// </summary>
		// Token: 0x06006F0B RID: 28427 RVA: 0x000A00D7 File Offset: 0x0009E2D7
		public void SetOperationToMax()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToMax_40(base.GetCppThis());
		}

		// Token: 0x06006F0C RID: 28428
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToMin_41(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the minimum of the corresponding pixels
		/// in Input1 and Input2. (Output = min(Input1, Input2))
		/// </summary>
		// Token: 0x06006F0D RID: 28429 RVA: 0x000A00E6 File Offset: 0x0009E2E6
		public void SetOperationToMin()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToMin_41(base.GetCppThis());
		}

		// Token: 0x06006F0E RID: 28430
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToMultiply_42(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the product of the corresponding pixels
		/// in Input1 and Input2.
		/// </summary>
		// Token: 0x06006F0F RID: 28431 RVA: 0x000A00F5 File Offset: 0x0009E2F5
		public void SetOperationToMultiply()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToMultiply_42(base.GetCppThis());
		}

		// Token: 0x06006F10 RID: 28432
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToMultiplyByK_43(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the product of ConstantK with the
		/// corresponding pixel in Input1. Input2 is not used.
		/// </summary>
		// Token: 0x06006F11 RID: 28433 RVA: 0x000A0104 File Offset: 0x0009E304
		public void SetOperationToMultiplyByK()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToMultiplyByK_43(base.GetCppThis());
		}

		// Token: 0x06006F12 RID: 28434
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToReplaceCByK_44(HandleRef pThis);

		/// <summary>
		/// Find every pixel in Input1 that equals ConstantC and set the corresponding pixels
		/// in the Output to ConstantK. Input2 is not used.
		/// </summary>
		// Token: 0x06006F13 RID: 28435 RVA: 0x000A0113 File Offset: 0x0009E313
		public void SetOperationToReplaceCByK()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToReplaceCByK_44(base.GetCppThis());
		}

		// Token: 0x06006F14 RID: 28436
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToSin_45(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the sine of the corresponding pixel
		/// in Input1. Input2 is not used.
		/// </summary>
		// Token: 0x06006F15 RID: 28437 RVA: 0x000A0122 File Offset: 0x0009E322
		public void SetOperationToSin()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToSin_45(base.GetCppThis());
		}

		// Token: 0x06006F16 RID: 28438
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToSquare_46(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the square of the corresponding pixel
		/// in Input1. Input2 is not used.
		/// </summary>
		// Token: 0x06006F17 RID: 28439 RVA: 0x000A0131 File Offset: 0x0009E331
		public void SetOperationToSquare()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToSquare_46(base.GetCppThis());
		}

		// Token: 0x06006F18 RID: 28440
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToSquareRoot_47(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the square root of the corresponding pixel
		/// in Input1. Input2 is not used.
		/// </summary>
		// Token: 0x06006F19 RID: 28441 RVA: 0x000A0140 File Offset: 0x0009E340
		public void SetOperationToSquareRoot()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToSquareRoot_47(base.GetCppThis());
		}

		// Token: 0x06006F1A RID: 28442
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMathematics_SetOperationToSubtract_48(HandleRef pThis);

		/// <summary>
		/// Set each pixel in the output image to the difference of the corresponding pixels
		/// in Input1 and Input2 (output = Input1 - Input2).
		/// </summary>
		// Token: 0x06006F1B RID: 28443 RVA: 0x000A014F File Offset: 0x0009E34F
		public void SetOperationToSubtract()
		{
			vtkImageMathematics.vtkImageMathematics_SetOperationToSubtract_48(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009A5 RID: 2469
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMathematics";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009A6 RID: 2470
		public new static readonly string MRClassNameKey = "class vtkImageMathematics";
	}
}
