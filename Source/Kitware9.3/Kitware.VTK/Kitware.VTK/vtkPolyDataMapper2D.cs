using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataMapper2D
	/// </summary>
	/// <remarks>
	///    draw vtkPolyData onto the image plane
	///
	/// vtkPolyDataMapper2D is a mapper that renders 3D polygonal data
	/// (vtkPolyData) onto the 2D image plane (i.e., the renderer's viewport).
	/// By default, the 3D data is transformed into 2D data by ignoring the
	/// z-coordinate of the 3D points in vtkPolyData, and taking the x-y values
	/// as local display values (i.e., pixel coordinates). Alternatively, you
	/// can provide a vtkCoordinate object that will transform the data into
	/// local display coordinates (use the vtkCoordinate::SetCoordinateSystem()
	/// methods to indicate which coordinate system you are transforming the
	/// data from).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMapper2D vtkActor2D
	/// </seealso>
	// Token: 0x020005C0 RID: 1472
	public class vtkPolyDataMapper2D : vtkMapper2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601019B RID: 65947 RVA: 0x00166CAB File Offset: 0x00164EAB
		static vtkPolyDataMapper2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataMapper2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataMapper2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601019C RID: 65948 RVA: 0x00166CD3 File Offset: 0x00164ED3
		public vtkPolyDataMapper2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601019D RID: 65949
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapper2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601019E RID: 65950 RVA: 0x00166CE4 File Offset: 0x00164EE4
		public new static vtkPolyDataMapper2D New()
		{
			vtkPolyDataMapper2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataMapper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601019F RID: 65951 RVA: 0x00166D38 File Offset: 0x00164F38
		public vtkPolyDataMapper2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataMapper2D.vtkPolyDataMapper2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060101A0 RID: 65952 RVA: 0x00166D7C File Offset: 0x00164F7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060101A1 RID: 65953
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_ColorByArrayComponent_01(HandleRef pThis, int arrayNum, int component);

		/// <summary>
		/// Choose which component of which field data array to color by.
		/// </summary>
		// Token: 0x060101A2 RID: 65954 RVA: 0x00166D87 File Offset: 0x00164F87
		public void ColorByArrayComponent(int arrayNum, int component)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_ColorByArrayComponent_01(base.GetCppThis(), arrayNum, component);
		}

		// Token: 0x060101A3 RID: 65955
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_ColorByArrayComponent_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int component);

		/// <summary>
		/// Choose which component of which field data array to color by.
		/// </summary>
		// Token: 0x060101A4 RID: 65956 RVA: 0x00166D98 File Offset: 0x00164F98
		public void ColorByArrayComponent(string arrayName, int component)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_ColorByArrayComponent_02(base.GetCppThis(), arrayName, component);
		}

		// Token: 0x060101A5 RID: 65957
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_CreateDefaultLookupTable_03(HandleRef pThis);

		/// <summary>
		/// Create default lookup table. Generally used to create one when none
		/// is available with the scalar data.
		/// </summary>
		// Token: 0x060101A6 RID: 65958 RVA: 0x00166DA9 File Offset: 0x00164FA9
		public virtual void CreateDefaultLookupTable()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_CreateDefaultLookupTable_03(base.GetCppThis());
		}

		// Token: 0x060101A7 RID: 65959
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper2D_GetArrayAccessMode_04(HandleRef pThis);

		/// <summary>
		/// Get the array name or number and component to color by.
		/// </summary>
		// Token: 0x060101A8 RID: 65960 RVA: 0x00166DB8 File Offset: 0x00164FB8
		public int GetArrayAccessMode()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetArrayAccessMode_04(base.GetCppThis());
		}

		// Token: 0x060101A9 RID: 65961
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper2D_GetArrayComponent_05(HandleRef pThis);

		/// <summary>
		/// Get the array name or number and component to color by.
		/// </summary>
		// Token: 0x060101AA RID: 65962 RVA: 0x00166DD8 File Offset: 0x00164FD8
		public int GetArrayComponent()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetArrayComponent_05(base.GetCppThis());
		}

		// Token: 0x060101AB RID: 65963
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper2D_GetArrayId_06(HandleRef pThis);

		/// <summary>
		/// Get the array name or number and component to color by.
		/// </summary>
		// Token: 0x060101AC RID: 65964 RVA: 0x00166DF8 File Offset: 0x00164FF8
		public int GetArrayId()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetArrayId_06(base.GetCppThis());
		}

		// Token: 0x060101AD RID: 65965
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapper2D_GetArrayName_07(HandleRef pThis);

		/// <summary>
		/// Get the array name or number and component to color by.
		/// </summary>
		// Token: 0x060101AE RID: 65966 RVA: 0x00166E18 File Offset: 0x00165018
		public string GetArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetArrayName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060101AF RID: 65967
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper2D_GetColorMode_08(HandleRef pThis);

		/// <summary>
		/// Control how the scalar data is mapped to colors.  By default
		/// (ColorModeToDefault), unsigned char scalars are treated as
		/// colors, and NOT mapped through the lookup table, while everything
		/// else is. ColorModeToDirectScalar extends ColorModeToDefault such
		/// that all integer types are treated as colors with values in the
		/// range 0-255 and floating types are treated as colors with values
		/// in the range 0.0-1.0. Setting
		/// ColorModeToMapScalars means that all scalar data will be mapped through
		/// the lookup table.  (Note that for multi-component scalars, the
		/// particular component to use for mapping can be specified using the
		/// ColorByArrayComponent() method.)
		/// </summary>
		// Token: 0x060101B0 RID: 65968 RVA: 0x00166E54 File Offset: 0x00165054
		public virtual int GetColorMode()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetColorMode_08(base.GetCppThis());
		}

		// Token: 0x060101B1 RID: 65969
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapper2D_GetColorModeAsString_09(HandleRef pThis);

		/// <summary>
		/// Return the method of coloring scalar data.
		/// </summary>
		// Token: 0x060101B2 RID: 65970 RVA: 0x00166E74 File Offset: 0x00165074
		public string GetColorModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetColorModeAsString_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060101B3 RID: 65971
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapper2D_GetInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the input to the mapper.
		/// </summary>
		// Token: 0x060101B4 RID: 65972 RVA: 0x00166EB0 File Offset: 0x001650B0
		public vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetInput_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x060101B5 RID: 65973
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapper2D_GetLookupTable_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a lookup table for the mapper to use.
		/// </summary>
		// Token: 0x060101B6 RID: 65974 RVA: 0x00166F20 File Offset: 0x00165120
		public vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetLookupTable_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		// Token: 0x060101B7 RID: 65975
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPolyDataMapper2D_GetMTime_12(HandleRef pThis);

		/// <summary>
		/// Overload standard modified time function. If lookup table is modified,
		/// then this object is modified as well.
		/// </summary>
		// Token: 0x060101B8 RID: 65976 RVA: 0x00166F90 File Offset: 0x00165190
		public override ulong GetMTime()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetMTime_12(base.GetCppThis());
		}

		// Token: 0x060101B9 RID: 65977
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataMapper2D_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060101BA RID: 65978 RVA: 0x00166FB0 File Offset: 0x001651B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x060101BB RID: 65979
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataMapper2D_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060101BC RID: 65980 RVA: 0x00166FD0 File Offset: 0x001651D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x060101BD RID: 65981
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper2D_GetScalarMode_15(HandleRef pThis);

		/// <summary>
		/// Control how the filter works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the filter will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the filter to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call ColorByArrayComponent before you call
		/// GetColors.
		/// </summary>
		// Token: 0x060101BE RID: 65982 RVA: 0x00166FEC File Offset: 0x001651EC
		public virtual int GetScalarMode()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetScalarMode_15(base.GetCppThis());
		}

		// Token: 0x060101BF RID: 65983
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapper2D_GetScalarRange_16(HandleRef pThis);

		/// <summary>
		/// Specify range in terms of scalar minimum and maximum (smin,smax). These
		/// values are used to map scalars into lookup table. Has no effect when
		/// UseLookupTableScalarRange is true.
		/// </summary>
		// Token: 0x060101C0 RID: 65984 RVA: 0x0016700C File Offset: 0x0016520C
		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetScalarRange_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060101C1 RID: 65985
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_GetScalarRange_17(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify range in terms of scalar minimum and maximum (smin,smax). These
		/// values are used to map scalars into lookup table. Has no effect when
		/// UseLookupTableScalarRange is true.
		/// </summary>
		// Token: 0x060101C2 RID: 65986 RVA: 0x00167054 File Offset: 0x00165254
		public virtual void GetScalarRange(IntPtr data)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetScalarRange_17(base.GetCppThis(), data);
		}

		// Token: 0x060101C3 RID: 65987
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper2D_GetScalarVisibility_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x060101C4 RID: 65988 RVA: 0x00167064 File Offset: 0x00165264
		public virtual int GetScalarVisibility()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetScalarVisibility_18(base.GetCppThis());
		}

		// Token: 0x060101C5 RID: 65989
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapper2D_GetTransformCoordinate_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a vtkCoordinate object to be used to transform the vtkPolyData
		/// point coordinates. By default (no vtkCoordinate specified), the point
		/// coordinates are taken as viewport coordinates (pixels in the viewport
		/// into which the mapper is rendering).
		/// </summary>
		// Token: 0x060101C6 RID: 65990 RVA: 0x00167084 File Offset: 0x00165284
		public virtual vtkCoordinate GetTransformCoordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetTransformCoordinate_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		// Token: 0x060101C7 RID: 65991
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataMapper2D_GetTransformCoordinateUseDouble_20(HandleRef pThis);

		/// <summary>
		/// Specify whether or not rounding to integers the transformed points when
		/// TransformCoordinate is set. By default, it does not use double precision.
		/// </summary>
		// Token: 0x060101C8 RID: 65992 RVA: 0x001670F4 File Offset: 0x001652F4
		public virtual bool GetTransformCoordinateUseDouble()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetTransformCoordinateUseDouble_20(base.GetCppThis()) != 0;
		}

		// Token: 0x060101C9 RID: 65993
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper2D_GetUseLookupTableScalarRange_21(HandleRef pThis);

		/// <summary>
		/// Control whether the mapper sets the lookuptable range based on its
		/// own ScalarRange, or whether it will use the LookupTable ScalarRange
		/// regardless of it's own setting. By default the Mapper is allowed to set
		/// the LookupTable range, but users who are sharing LookupTables between
		/// mappers/actors will probably wish to force the mapper to use the
		/// LookupTable unchanged.
		/// </summary>
		// Token: 0x060101CA RID: 65994 RVA: 0x0016711C File Offset: 0x0016531C
		public virtual int GetUseLookupTableScalarRange()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetUseLookupTableScalarRange_21(base.GetCppThis());
		}

		// Token: 0x060101CB RID: 65995
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper2D_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060101CC RID: 65996 RVA: 0x0016713C File Offset: 0x0016533C
		public override int IsA(string type)
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x060101CD RID: 65997
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataMapper2D_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060101CE RID: 65998 RVA: 0x0016715C File Offset: 0x0016535C
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_IsTypeOf_23(type);
		}

		// Token: 0x060101CF RID: 65999
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapper2D_MapScalars_24(HandleRef pThis, double alpha, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Map the scalars (if there are any scalars and ScalarVisibility is on)
		/// through the lookup table, returning an unsigned char RGBA array. This is
		/// typically done as part of the rendering process. The alpha parameter
		/// allows the blending of the scalars with an additional alpha (typically
		/// which comes from a vtkActor, etc.)
		/// </summary>
		// Token: 0x060101D0 RID: 66000 RVA: 0x00167178 File Offset: 0x00165378
		public vtkUnsignedCharArray MapScalars(double alpha)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_MapScalars_24(base.GetCppThis(), alpha, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x060101D1 RID: 66001
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapper2D_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060101D2 RID: 66002 RVA: 0x001671E8 File Offset: 0x001653E8
		public new vtkPolyDataMapper2D NewInstance()
		{
			vtkPolyDataMapper2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataMapper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060101D3 RID: 66003
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataMapper2D_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060101D4 RID: 66004 RVA: 0x00167244 File Offset: 0x00165444
		public new static vtkPolyDataMapper2D SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataMapper2D vtkPolyDataMapper2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataMapper2D = (vtkPolyDataMapper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataMapper2D.Register(null);
				}
			}
			return vtkPolyDataMapper2D;
		}

		// Token: 0x060101D5 RID: 66005
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_ScalarVisibilityOff_28(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x060101D6 RID: 66006 RVA: 0x001672C3 File Offset: 0x001654C3
		public virtual void ScalarVisibilityOff()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_ScalarVisibilityOff_28(base.GetCppThis());
		}

		// Token: 0x060101D7 RID: 66007
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_ScalarVisibilityOn_29(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x060101D8 RID: 66008 RVA: 0x001672D2 File Offset: 0x001654D2
		public virtual void ScalarVisibilityOn()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_ScalarVisibilityOn_29(base.GetCppThis());
		}

		// Token: 0x060101D9 RID: 66009
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetColorMode_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how the scalar data is mapped to colors.  By default
		/// (ColorModeToDefault), unsigned char scalars are treated as
		/// colors, and NOT mapped through the lookup table, while everything
		/// else is. ColorModeToDirectScalar extends ColorModeToDefault such
		/// that all integer types are treated as colors with values in the
		/// range 0-255 and floating types are treated as colors with values
		/// in the range 0.0-1.0. Setting
		/// ColorModeToMapScalars means that all scalar data will be mapped through
		/// the lookup table.  (Note that for multi-component scalars, the
		/// particular component to use for mapping can be specified using the
		/// ColorByArrayComponent() method.)
		/// </summary>
		// Token: 0x060101DA RID: 66010 RVA: 0x001672E1 File Offset: 0x001654E1
		public virtual void SetColorMode(int _arg)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetColorMode_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060101DB RID: 66011
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetColorModeToDefault_31(HandleRef pThis);

		/// <summary>
		/// Control how the scalar data is mapped to colors.  By default
		/// (ColorModeToDefault), unsigned char scalars are treated as
		/// colors, and NOT mapped through the lookup table, while everything
		/// else is. ColorModeToDirectScalar extends ColorModeToDefault such
		/// that all integer types are treated as colors with values in the
		/// range 0-255 and floating types are treated as colors with values
		/// in the range 0.0-1.0. Setting
		/// ColorModeToMapScalars means that all scalar data will be mapped through
		/// the lookup table.  (Note that for multi-component scalars, the
		/// particular component to use for mapping can be specified using the
		/// ColorByArrayComponent() method.)
		/// </summary>
		// Token: 0x060101DC RID: 66012 RVA: 0x001672F1 File Offset: 0x001654F1
		public void SetColorModeToDefault()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetColorModeToDefault_31(base.GetCppThis());
		}

		// Token: 0x060101DD RID: 66013
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetColorModeToDirectScalars_32(HandleRef pThis);

		/// <summary>
		/// Control how the scalar data is mapped to colors.  By default
		/// (ColorModeToDefault), unsigned char scalars are treated as
		/// colors, and NOT mapped through the lookup table, while everything
		/// else is. ColorModeToDirectScalar extends ColorModeToDefault such
		/// that all integer types are treated as colors with values in the
		/// range 0-255 and floating types are treated as colors with values
		/// in the range 0.0-1.0. Setting
		/// ColorModeToMapScalars means that all scalar data will be mapped through
		/// the lookup table.  (Note that for multi-component scalars, the
		/// particular component to use for mapping can be specified using the
		/// ColorByArrayComponent() method.)
		/// </summary>
		// Token: 0x060101DE RID: 66014 RVA: 0x00167300 File Offset: 0x00165500
		public void SetColorModeToDirectScalars()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetColorModeToDirectScalars_32(base.GetCppThis());
		}

		// Token: 0x060101DF RID: 66015
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetColorModeToMapScalars_33(HandleRef pThis);

		/// <summary>
		/// Control how the scalar data is mapped to colors.  By default
		/// (ColorModeToDefault), unsigned char scalars are treated as
		/// colors, and NOT mapped through the lookup table, while everything
		/// else is. ColorModeToDirectScalar extends ColorModeToDefault such
		/// that all integer types are treated as colors with values in the
		/// range 0-255 and floating types are treated as colors with values
		/// in the range 0.0-1.0. Setting
		/// ColorModeToMapScalars means that all scalar data will be mapped through
		/// the lookup table.  (Note that for multi-component scalars, the
		/// particular component to use for mapping can be specified using the
		/// ColorByArrayComponent() method.)
		/// </summary>
		// Token: 0x060101E0 RID: 66016 RVA: 0x0016730F File Offset: 0x0016550F
		public void SetColorModeToMapScalars()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetColorModeToMapScalars_33(base.GetCppThis());
		}

		// Token: 0x060101E1 RID: 66017
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetInputData_34(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the input to the mapper.
		/// </summary>
		// Token: 0x060101E2 RID: 66018 RVA: 0x00167320 File Offset: 0x00165520
		public void SetInputData(vtkPolyData arg0)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetInputData_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060101E3 RID: 66019
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetLookupTable_35(HandleRef pThis, HandleRef lut);

		/// <summary>
		/// Specify a lookup table for the mapper to use.
		/// </summary>
		// Token: 0x060101E4 RID: 66020 RVA: 0x00167350 File Offset: 0x00165550
		public void SetLookupTable(vtkScalarsToColors lut)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetLookupTable_35(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		// Token: 0x060101E5 RID: 66021
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetScalarMode_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how the filter works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the filter will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the filter to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call ColorByArrayComponent before you call
		/// GetColors.
		/// </summary>
		// Token: 0x060101E6 RID: 66022 RVA: 0x0016737F File Offset: 0x0016557F
		public virtual void SetScalarMode(int _arg)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarMode_36(base.GetCppThis(), _arg);
		}

		// Token: 0x060101E7 RID: 66023
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetScalarModeToDefault_37(HandleRef pThis);

		/// <summary>
		/// Control how the filter works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the filter will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the filter to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call ColorByArrayComponent before you call
		/// GetColors.
		/// </summary>
		// Token: 0x060101E8 RID: 66024 RVA: 0x0016738F File Offset: 0x0016558F
		public void SetScalarModeToDefault()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarModeToDefault_37(base.GetCppThis());
		}

		// Token: 0x060101E9 RID: 66025
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetScalarModeToUseCellData_38(HandleRef pThis);

		/// <summary>
		/// Control how the filter works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the filter will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the filter to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call ColorByArrayComponent before you call
		/// GetColors.
		/// </summary>
		// Token: 0x060101EA RID: 66026 RVA: 0x0016739E File Offset: 0x0016559E
		public void SetScalarModeToUseCellData()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarModeToUseCellData_38(base.GetCppThis());
		}

		// Token: 0x060101EB RID: 66027
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetScalarModeToUseCellFieldData_39(HandleRef pThis);

		/// <summary>
		/// Control how the filter works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the filter will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the filter to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call ColorByArrayComponent before you call
		/// GetColors.
		/// </summary>
		// Token: 0x060101EC RID: 66028 RVA: 0x001673AD File Offset: 0x001655AD
		public void SetScalarModeToUseCellFieldData()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarModeToUseCellFieldData_39(base.GetCppThis());
		}

		// Token: 0x060101ED RID: 66029
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetScalarModeToUsePointData_40(HandleRef pThis);

		/// <summary>
		/// Control how the filter works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the filter will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the filter to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call ColorByArrayComponent before you call
		/// GetColors.
		/// </summary>
		// Token: 0x060101EE RID: 66030 RVA: 0x001673BC File Offset: 0x001655BC
		public void SetScalarModeToUsePointData()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarModeToUsePointData_40(base.GetCppThis());
		}

		// Token: 0x060101EF RID: 66031
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetScalarModeToUsePointFieldData_41(HandleRef pThis);

		/// <summary>
		/// Control how the filter works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the filter will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the filter to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call ColorByArrayComponent before you call
		/// GetColors.
		/// </summary>
		// Token: 0x060101F0 RID: 66032 RVA: 0x001673CB File Offset: 0x001655CB
		public void SetScalarModeToUsePointFieldData()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarModeToUsePointFieldData_41(base.GetCppThis());
		}

		// Token: 0x060101F1 RID: 66033
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetScalarRange_42(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify range in terms of scalar minimum and maximum (smin,smax). These
		/// values are used to map scalars into lookup table. Has no effect when
		/// UseLookupTableScalarRange is true.
		/// </summary>
		// Token: 0x060101F2 RID: 66034 RVA: 0x001673DA File Offset: 0x001655DA
		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarRange_42(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060101F3 RID: 66035
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetScalarRange_43(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify range in terms of scalar minimum and maximum (smin,smax). These
		/// values are used to map scalars into lookup table. Has no effect when
		/// UseLookupTableScalarRange is true.
		/// </summary>
		// Token: 0x060101F4 RID: 66036 RVA: 0x001673EB File Offset: 0x001655EB
		public void SetScalarRange(IntPtr _arg)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarRange_43(base.GetCppThis(), _arg);
		}

		// Token: 0x060101F5 RID: 66037
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetScalarVisibility_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off flag to control whether scalar data is used to color objects.
		/// </summary>
		// Token: 0x060101F6 RID: 66038 RVA: 0x001673FB File Offset: 0x001655FB
		public virtual void SetScalarVisibility(int _arg)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarVisibility_44(base.GetCppThis(), _arg);
		}

		// Token: 0x060101F7 RID: 66039
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetTransformCoordinate_45(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify a vtkCoordinate object to be used to transform the vtkPolyData
		/// point coordinates. By default (no vtkCoordinate specified), the point
		/// coordinates are taken as viewport coordinates (pixels in the viewport
		/// into which the mapper is rendering).
		/// </summary>
		// Token: 0x060101F8 RID: 66040 RVA: 0x0016740C File Offset: 0x0016560C
		public virtual void SetTransformCoordinate(vtkCoordinate arg0)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetTransformCoordinate_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060101F9 RID: 66041
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetTransformCoordinateUseDouble_46(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether or not rounding to integers the transformed points when
		/// TransformCoordinate is set. By default, it does not use double precision.
		/// </summary>
		// Token: 0x060101FA RID: 66042 RVA: 0x0016743B File Offset: 0x0016563B
		public virtual void SetTransformCoordinateUseDouble(bool _arg)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetTransformCoordinateUseDouble_46(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060101FB RID: 66043
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_SetUseLookupTableScalarRange_47(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether the mapper sets the lookuptable range based on its
		/// own ScalarRange, or whether it will use the LookupTable ScalarRange
		/// regardless of it's own setting. By default the Mapper is allowed to set
		/// the LookupTable range, but users who are sharing LookupTables between
		/// mappers/actors will probably wish to force the mapper to use the
		/// LookupTable unchanged.
		/// </summary>
		// Token: 0x060101FC RID: 66044 RVA: 0x00167453 File Offset: 0x00165653
		public virtual void SetUseLookupTableScalarRange(int _arg)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetUseLookupTableScalarRange_47(base.GetCppThis(), _arg);
		}

		// Token: 0x060101FD RID: 66045
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_ShallowCopy_48(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Make a shallow copy of this mapper.
		/// </summary>
		// Token: 0x060101FE RID: 66046 RVA: 0x00167464 File Offset: 0x00165664
		public override void ShallowCopy(vtkAbstractMapper m)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_ShallowCopy_48(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x060101FF RID: 66047
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_TransformCoordinateUseDoubleOff_49(HandleRef pThis);

		/// <summary>
		/// Specify whether or not rounding to integers the transformed points when
		/// TransformCoordinate is set. By default, it does not use double precision.
		/// </summary>
		// Token: 0x06010200 RID: 66048 RVA: 0x00167493 File Offset: 0x00165693
		public virtual void TransformCoordinateUseDoubleOff()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_TransformCoordinateUseDoubleOff_49(base.GetCppThis());
		}

		// Token: 0x06010201 RID: 66049
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_TransformCoordinateUseDoubleOn_50(HandleRef pThis);

		/// <summary>
		/// Specify whether or not rounding to integers the transformed points when
		/// TransformCoordinate is set. By default, it does not use double precision.
		/// </summary>
		// Token: 0x06010202 RID: 66050 RVA: 0x001674A2 File Offset: 0x001656A2
		public virtual void TransformCoordinateUseDoubleOn()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_TransformCoordinateUseDoubleOn_50(base.GetCppThis());
		}

		// Token: 0x06010203 RID: 66051
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_UseLookupTableScalarRangeOff_51(HandleRef pThis);

		/// <summary>
		/// Control whether the mapper sets the lookuptable range based on its
		/// own ScalarRange, or whether it will use the LookupTable ScalarRange
		/// regardless of it's own setting. By default the Mapper is allowed to set
		/// the LookupTable range, but users who are sharing LookupTables between
		/// mappers/actors will probably wish to force the mapper to use the
		/// LookupTable unchanged.
		/// </summary>
		// Token: 0x06010204 RID: 66052 RVA: 0x001674B1 File Offset: 0x001656B1
		public virtual void UseLookupTableScalarRangeOff()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_UseLookupTableScalarRangeOff_51(base.GetCppThis());
		}

		// Token: 0x06010205 RID: 66053
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataMapper2D_UseLookupTableScalarRangeOn_52(HandleRef pThis);

		/// <summary>
		/// Control whether the mapper sets the lookuptable range based on its
		/// own ScalarRange, or whether it will use the LookupTable ScalarRange
		/// regardless of it's own setting. By default the Mapper is allowed to set
		/// the LookupTable range, but users who are sharing LookupTables between
		/// mappers/actors will probably wish to force the mapper to use the
		/// LookupTable unchanged.
		/// </summary>
		// Token: 0x06010206 RID: 66054 RVA: 0x001674C0 File Offset: 0x001656C0
		public virtual void UseLookupTableScalarRangeOn()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_UseLookupTableScalarRangeOn_52(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012C2 RID: 4802
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataMapper2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012C3 RID: 4803
		public new static readonly string MRClassNameKey = "class vtkPolyDataMapper2D";
	}
}
