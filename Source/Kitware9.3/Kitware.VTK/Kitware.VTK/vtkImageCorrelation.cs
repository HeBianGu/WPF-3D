using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageCorrelation
	/// </summary>
	/// <remarks>
	///    Correlation imageof the two inputs.
	///
	/// vtkImageCorrelation finds the correlation between two data sets.
	/// SetDimensionality determines
	/// whether the Correlation will be 3D, 2D or 1D.
	/// The default is a 2D Correlation.  The Output type will be double.
	/// The output size will match the size of the first input.
	/// The second input is considered the correlation kernel.
	/// </remarks>
	// Token: 0x02000482 RID: 1154
	public class vtkImageCorrelation : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D46F RID: 54383 RVA: 0x0012792F File Offset: 0x00125B2F
		static vtkImageCorrelation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageCorrelation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCorrelation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D470 RID: 54384 RVA: 0x00127957 File Offset: 0x00125B57
		public vtkImageCorrelation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D471 RID: 54385
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCorrelation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D472 RID: 54386 RVA: 0x00127968 File Offset: 0x00125B68
		public new static vtkImageCorrelation New()
		{
			vtkImageCorrelation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCorrelation.vtkImageCorrelation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCorrelation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D473 RID: 54387 RVA: 0x001279BC File Offset: 0x00125BBC
		public vtkImageCorrelation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageCorrelation.vtkImageCorrelation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D474 RID: 54388 RVA: 0x00127A00 File Offset: 0x00125C00
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D475 RID: 54389
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCorrelation_GetDimensionality_01(HandleRef pThis);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...).
		/// The default is 2.
		/// </summary>
		// Token: 0x0600D476 RID: 54390 RVA: 0x00127A0C File Offset: 0x00125C0C
		public virtual int GetDimensionality()
		{
			return vtkImageCorrelation.vtkImageCorrelation_GetDimensionality_01(base.GetCppThis());
		}

		// Token: 0x0600D477 RID: 54391
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCorrelation_GetDimensionalityMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...).
		/// The default is 2.
		/// </summary>
		// Token: 0x0600D478 RID: 54392 RVA: 0x00127A2C File Offset: 0x00125C2C
		public virtual int GetDimensionalityMaxValue()
		{
			return vtkImageCorrelation.vtkImageCorrelation_GetDimensionalityMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600D479 RID: 54393
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCorrelation_GetDimensionalityMinValue_03(HandleRef pThis);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...).
		/// The default is 2.
		/// </summary>
		// Token: 0x0600D47A RID: 54394 RVA: 0x00127A4C File Offset: 0x00125C4C
		public virtual int GetDimensionalityMinValue()
		{
			return vtkImageCorrelation.vtkImageCorrelation_GetDimensionalityMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600D47B RID: 54395
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCorrelation_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D47C RID: 54396 RVA: 0x00127A6C File Offset: 0x00125C6C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageCorrelation.vtkImageCorrelation_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600D47D RID: 54397
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCorrelation_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D47E RID: 54398 RVA: 0x00127A8C File Offset: 0x00125C8C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageCorrelation.vtkImageCorrelation_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600D47F RID: 54399
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCorrelation_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D480 RID: 54400 RVA: 0x00127AA8 File Offset: 0x00125CA8
		public override int IsA(string type)
		{
			return vtkImageCorrelation.vtkImageCorrelation_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600D481 RID: 54401
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCorrelation_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D482 RID: 54402 RVA: 0x00127AC8 File Offset: 0x00125CC8
		public new static int IsTypeOf(string type)
		{
			return vtkImageCorrelation.vtkImageCorrelation_IsTypeOf_07(type);
		}

		// Token: 0x0600D483 RID: 54403
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCorrelation_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D484 RID: 54404 RVA: 0x00127AE4 File Offset: 0x00125CE4
		public new vtkImageCorrelation NewInstance()
		{
			vtkImageCorrelation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCorrelation.vtkImageCorrelation_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCorrelation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D485 RID: 54405
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCorrelation_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D486 RID: 54406 RVA: 0x00127B40 File Offset: 0x00125D40
		public new static vtkImageCorrelation SafeDownCast(vtkObjectBase o)
		{
			vtkImageCorrelation vtkImageCorrelation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCorrelation.vtkImageCorrelation_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCorrelation = (vtkImageCorrelation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCorrelation.Register(null);
				}
			}
			return vtkImageCorrelation;
		}

		// Token: 0x0600D487 RID: 54407
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCorrelation_SetDimensionality_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Determines how the input is interpreted (set of 2d slices ...).
		/// The default is 2.
		/// </summary>
		// Token: 0x0600D488 RID: 54408 RVA: 0x00127BBF File Offset: 0x00125DBF
		public virtual void SetDimensionality(int _arg)
		{
			vtkImageCorrelation.vtkImageCorrelation_SetDimensionality_11(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D489 RID: 54409
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCorrelation_SetInput1Data_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the input image.
		/// </summary>
		// Token: 0x0600D48A RID: 54410 RVA: 0x00127BD0 File Offset: 0x00125DD0
		public virtual void SetInput1Data(vtkDataObject arg0)
		{
			vtkImageCorrelation.vtkImageCorrelation_SetInput1Data_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D48B RID: 54411
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCorrelation_SetInput2Data_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the correlation kernel.
		/// </summary>
		// Token: 0x0600D48C RID: 54412 RVA: 0x00127C00 File Offset: 0x00125E00
		public virtual void SetInput2Data(vtkDataObject arg0)
		{
			vtkImageCorrelation.vtkImageCorrelation_SetInput2Data_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FAC RID: 4012
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageCorrelation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FAD RID: 4013
		public new static readonly string MRClassNameKey = "class vtkImageCorrelation";
	}
}
