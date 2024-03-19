using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMaskPolyData
	/// </summary>
	/// <remarks>
	///    sample subset of input polygonal data cells
	///
	/// vtkMaskPolyData is a filter that sub-samples the cells of input polygonal
	/// data. The user specifies every nth item, with an initial offset to begin
	/// sampling.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMaskPoints
	/// </seealso>
	// Token: 0x0200097B RID: 2427
	public class vtkMaskPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060194A3 RID: 103587 RVA: 0x00233AA7 File Offset: 0x00231CA7
		static vtkMaskPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMaskPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMaskPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060194A4 RID: 103588 RVA: 0x00233ACF File Offset: 0x00231CCF
		public vtkMaskPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060194A5 RID: 103589
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMaskPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060194A6 RID: 103590 RVA: 0x00233AE0 File Offset: 0x00231CE0
		public new static vtkMaskPolyData New()
		{
			vtkMaskPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMaskPolyData.vtkMaskPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaskPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060194A7 RID: 103591 RVA: 0x00233B34 File Offset: 0x00231D34
		public vtkMaskPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMaskPolyData.vtkMaskPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060194A8 RID: 103592 RVA: 0x00233B78 File Offset: 0x00231D78
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060194A9 RID: 103593
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskPolyData_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060194AA RID: 103594 RVA: 0x00233B84 File Offset: 0x00231D84
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMaskPolyData.vtkMaskPolyData_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060194AB RID: 103595
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskPolyData_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060194AC RID: 103596 RVA: 0x00233BA4 File Offset: 0x00231DA4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMaskPolyData.vtkMaskPolyData_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060194AD RID: 103597
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskPolyData_GetOffset_03(HandleRef pThis);

		/// <summary>
		/// Start with this entity (cell).
		/// </summary>
		// Token: 0x060194AE RID: 103598 RVA: 0x00233BC0 File Offset: 0x00231DC0
		public virtual long GetOffset()
		{
			return vtkMaskPolyData.vtkMaskPolyData_GetOffset_03(base.GetCppThis());
		}

		// Token: 0x060194AF RID: 103599
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskPolyData_GetOffsetMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Start with this entity (cell).
		/// </summary>
		// Token: 0x060194B0 RID: 103600 RVA: 0x00233BE0 File Offset: 0x00231DE0
		public virtual long GetOffsetMaxValue()
		{
			return vtkMaskPolyData.vtkMaskPolyData_GetOffsetMaxValue_04(base.GetCppThis());
		}

		// Token: 0x060194B1 RID: 103601
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMaskPolyData_GetOffsetMinValue_05(HandleRef pThis);

		/// <summary>
		/// Start with this entity (cell).
		/// </summary>
		// Token: 0x060194B2 RID: 103602 RVA: 0x00233C00 File Offset: 0x00231E00
		public virtual long GetOffsetMinValue()
		{
			return vtkMaskPolyData.vtkMaskPolyData_GetOffsetMinValue_05(base.GetCppThis());
		}

		// Token: 0x060194B3 RID: 103603
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPolyData_GetOnRatio_06(HandleRef pThis);

		/// <summary>
		/// Turn on every nth entity (cell).
		/// </summary>
		// Token: 0x060194B4 RID: 103604 RVA: 0x00233C20 File Offset: 0x00231E20
		public virtual int GetOnRatio()
		{
			return vtkMaskPolyData.vtkMaskPolyData_GetOnRatio_06(base.GetCppThis());
		}

		// Token: 0x060194B5 RID: 103605
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPolyData_GetOnRatioMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Turn on every nth entity (cell).
		/// </summary>
		// Token: 0x060194B6 RID: 103606 RVA: 0x00233C40 File Offset: 0x00231E40
		public virtual int GetOnRatioMaxValue()
		{
			return vtkMaskPolyData.vtkMaskPolyData_GetOnRatioMaxValue_07(base.GetCppThis());
		}

		// Token: 0x060194B7 RID: 103607
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPolyData_GetOnRatioMinValue_08(HandleRef pThis);

		/// <summary>
		/// Turn on every nth entity (cell).
		/// </summary>
		// Token: 0x060194B8 RID: 103608 RVA: 0x00233C60 File Offset: 0x00231E60
		public virtual int GetOnRatioMinValue()
		{
			return vtkMaskPolyData.vtkMaskPolyData_GetOnRatioMinValue_08(base.GetCppThis());
		}

		// Token: 0x060194B9 RID: 103609
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPolyData_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060194BA RID: 103610 RVA: 0x00233C80 File Offset: 0x00231E80
		public override int IsA(string type)
		{
			return vtkMaskPolyData.vtkMaskPolyData_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060194BB RID: 103611
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMaskPolyData_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060194BC RID: 103612 RVA: 0x00233CA0 File Offset: 0x00231EA0
		public new static int IsTypeOf(string type)
		{
			return vtkMaskPolyData.vtkMaskPolyData_IsTypeOf_10(type);
		}

		// Token: 0x060194BD RID: 103613
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMaskPolyData_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060194BE RID: 103614 RVA: 0x00233CBC File Offset: 0x00231EBC
		public new vtkMaskPolyData NewInstance()
		{
			vtkMaskPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMaskPolyData.vtkMaskPolyData_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaskPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060194BF RID: 103615
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMaskPolyData_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060194C0 RID: 103616 RVA: 0x00233D18 File Offset: 0x00231F18
		public new static vtkMaskPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkMaskPolyData vtkMaskPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMaskPolyData.vtkMaskPolyData_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMaskPolyData = (vtkMaskPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMaskPolyData.Register(null);
				}
			}
			return vtkMaskPolyData;
		}

		// Token: 0x060194C1 RID: 103617
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPolyData_SetOffset_14(HandleRef pThis, long _arg);

		/// <summary>
		/// Start with this entity (cell).
		/// </summary>
		// Token: 0x060194C2 RID: 103618 RVA: 0x00233D97 File Offset: 0x00231F97
		public virtual void SetOffset(long _arg)
		{
			vtkMaskPolyData.vtkMaskPolyData_SetOffset_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060194C3 RID: 103619
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMaskPolyData_SetOnRatio_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on every nth entity (cell).
		/// </summary>
		// Token: 0x060194C4 RID: 103620 RVA: 0x00233DA7 File Offset: 0x00231FA7
		public virtual void SetOnRatio(int _arg)
		{
			vtkMaskPolyData.vtkMaskPolyData_SetOnRatio_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BB2 RID: 7090
		public new const string MRFullTypeName = "Kitware.VTK.vtkMaskPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BB3 RID: 7091
		public new static readonly string MRClassNameKey = "class vtkMaskPolyData";
	}
}
