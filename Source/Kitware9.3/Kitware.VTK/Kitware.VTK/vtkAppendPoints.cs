using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAppendPoints
	/// </summary>
	/// <remarks>
	///    appends points of one or more vtkPolyData data sets
	///
	///
	/// vtkAppendPoints is a filter that appends the points and associated data
	/// of one or more polygonal (vtkPolyData) datasets. This filter can optionally
	/// add a new array marking the input index that the point came from.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAppendFilter vtkAppendPolyData
	/// </seealso>
	// Token: 0x02000871 RID: 2161
	public class vtkAppendPoints : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060166FA RID: 91898 RVA: 0x001F8BC7 File Offset: 0x001F6DC7
		static vtkAppendPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAppendPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060166FB RID: 91899 RVA: 0x001F8BEF File Offset: 0x001F6DEF
		public vtkAppendPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060166FC RID: 91900
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166FD RID: 91901 RVA: 0x001F8C00 File Offset: 0x001F6E00
		public new static vtkAppendPoints New()
		{
			vtkAppendPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendPoints.vtkAppendPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166FE RID: 91902 RVA: 0x001F8C54 File Offset: 0x001F6E54
		public vtkAppendPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAppendPoints.vtkAppendPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060166FF RID: 91903 RVA: 0x001F8C98 File Offset: 0x001F6E98
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016700 RID: 91904
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendPoints_GetInputIdArrayName_01(HandleRef pThis);

		/// <summary>
		/// Sets the output array name to fill with the input connection index
		/// for each point. This provides a way to trace a point back to a
		/// particular input. If this is nullptr (the default), the array is not generated.
		/// </summary>
		// Token: 0x06016701 RID: 91905 RVA: 0x001F8CA4 File Offset: 0x001F6EA4
		public virtual string GetInputIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAppendPoints.vtkAppendPoints_GetInputIdArrayName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016702 RID: 91906
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendPoints_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016703 RID: 91907 RVA: 0x001F8CE0 File Offset: 0x001F6EE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAppendPoints.vtkAppendPoints_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06016704 RID: 91908
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendPoints_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016705 RID: 91909 RVA: 0x001F8D00 File Offset: 0x001F6F00
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAppendPoints.vtkAppendPoints_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06016706 RID: 91910
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendPoints_GetOutputPointsPrecision_04(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output type. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings. If the desired precision is
		/// DEFAULT_PRECISION and any of the inputs are double precision, then the
		/// output precision will be double precision. Otherwise, if the desired
		/// precision is DEFAULT_PRECISION and all the inputs are single precision,
		/// then the output will be single precision.
		/// </summary>
		// Token: 0x06016707 RID: 91911 RVA: 0x001F8D1C File Offset: 0x001F6F1C
		public virtual int GetOutputPointsPrecision()
		{
			return vtkAppendPoints.vtkAppendPoints_GetOutputPointsPrecision_04(base.GetCppThis());
		}

		// Token: 0x06016708 RID: 91912
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendPoints_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016709 RID: 91913 RVA: 0x001F8D3C File Offset: 0x001F6F3C
		public override int IsA(string type)
		{
			return vtkAppendPoints.vtkAppendPoints_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601670A RID: 91914
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendPoints_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601670B RID: 91915 RVA: 0x001F8D5C File Offset: 0x001F6F5C
		public new static int IsTypeOf(string type)
		{
			return vtkAppendPoints.vtkAppendPoints_IsTypeOf_06(type);
		}

		// Token: 0x0601670C RID: 91916
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendPoints_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601670D RID: 91917 RVA: 0x001F8D78 File Offset: 0x001F6F78
		public new vtkAppendPoints NewInstance()
		{
			vtkAppendPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendPoints.vtkAppendPoints_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601670E RID: 91918
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendPoints_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601670F RID: 91919 RVA: 0x001F8DD4 File Offset: 0x001F6FD4
		public new static vtkAppendPoints SafeDownCast(vtkObjectBase o)
		{
			vtkAppendPoints vtkAppendPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendPoints.vtkAppendPoints_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAppendPoints = (vtkAppendPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAppendPoints.Register(null);
				}
			}
			return vtkAppendPoints;
		}

		// Token: 0x06016710 RID: 91920
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendPoints_SetInputIdArrayName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Sets the output array name to fill with the input connection index
		/// for each point. This provides a way to trace a point back to a
		/// particular input. If this is nullptr (the default), the array is not generated.
		/// </summary>
		// Token: 0x06016711 RID: 91921 RVA: 0x001F8E53 File Offset: 0x001F7053
		public virtual void SetInputIdArrayName(string _arg)
		{
			vtkAppendPoints.vtkAppendPoints_SetInputIdArrayName_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06016712 RID: 91922
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendPoints_SetOutputPointsPrecision_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output type. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings. If the desired precision is
		/// DEFAULT_PRECISION and any of the inputs are double precision, then the
		/// output precision will be double precision. Otherwise, if the desired
		/// precision is DEFAULT_PRECISION and all the inputs are single precision,
		/// then the output will be single precision.
		/// </summary>
		// Token: 0x06016713 RID: 91923 RVA: 0x001F8E63 File Offset: 0x001F7063
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkAppendPoints.vtkAppendPoints_SetOutputPointsPrecision_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001938 RID: 6456
		public new const string MRFullTypeName = "Kitware.VTK.vtkAppendPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001939 RID: 6457
		public new static readonly string MRClassNameKey = "class vtkAppendPoints";
	}
}
