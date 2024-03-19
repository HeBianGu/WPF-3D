using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSplineFilter
	/// </summary>
	/// <remarks>
	///    generate uniformly subdivided polylines from a set of input polyline using a vtkSpline
	///
	/// vtkSplineFilter is a filter that generates an output polylines from an
	/// input set of polylines. The polylines are uniformly subdivided and produced
	/// with the help of a vtkSpline class that the user can specify (by default a
	/// vtkCardinalSpline is used). The number of subdivisions of the line can be
	/// controlled in several ways. The user can either specify the number of
	/// subdivisions or a length of each subdivision can be provided (and the
	/// class will figure out how many subdivisions is required over the whole
	/// polyline). The maximum number of subdivisions can also be set.
	///
	/// The output of this filter is a polyline per input polyline (or line). New
	/// points and texture coordinates are created. Point data is interpolated and
	/// cell data passed on. Any polylines with less than two points, or who have
	/// coincident points, are ignored.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRibbonFilter vtkTubeFilter
	/// </seealso>
	// Token: 0x020008E1 RID: 2273
	public class vtkSplineFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017797 RID: 96151 RVA: 0x0020F0DB File Offset: 0x0020D2DB
		static vtkSplineFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSplineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplineFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017798 RID: 96152 RVA: 0x0020F103 File Offset: 0x0020D303
		public vtkSplineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017799 RID: 96153
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct the class with no limit on the number of subdivisions
		/// and using an instance of vtkCardinalSpline to perform interpolation.
		/// </summary>
		// Token: 0x0601779A RID: 96154 RVA: 0x0020F114 File Offset: 0x0020D314
		public new static vtkSplineFilter New()
		{
			vtkSplineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineFilter.vtkSplineFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct the class with no limit on the number of subdivisions
		/// and using an instance of vtkCardinalSpline to perform interpolation.
		/// </summary>
		// Token: 0x0601779B RID: 96155 RVA: 0x0020F168 File Offset: 0x0020D368
		public vtkSplineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSplineFilter.vtkSplineFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601779C RID: 96156 RVA: 0x0020F1AC File Offset: 0x0020D3AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601779D RID: 96157
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineFilter_GetGenerateTCoords_01(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the output polyline. The texture coordinates
		/// can be generated in three ways: a normalized (0,1) generation;
		/// based on the length (divided by the texture length); and by using
		/// the input scalar values.
		/// </summary>
		// Token: 0x0601779E RID: 96158 RVA: 0x0020F1B8 File Offset: 0x0020D3B8
		public virtual int GetGenerateTCoords()
		{
			return vtkSplineFilter.vtkSplineFilter_GetGenerateTCoords_01(base.GetCppThis());
		}

		// Token: 0x0601779F RID: 96159
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineFilter_GetGenerateTCoordsAsString_02(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the output polyline. The texture coordinates
		/// can be generated in three ways: a normalized (0,1) generation;
		/// based on the length (divided by the texture length); and by using
		/// the input scalar values.
		/// </summary>
		// Token: 0x060177A0 RID: 96160 RVA: 0x0020F1D8 File Offset: 0x0020D3D8
		public string GetGenerateTCoordsAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkSplineFilter.vtkSplineFilter_GetGenerateTCoordsAsString_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060177A1 RID: 96161
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineFilter_GetGenerateTCoordsMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the output polyline. The texture coordinates
		/// can be generated in three ways: a normalized (0,1) generation;
		/// based on the length (divided by the texture length); and by using
		/// the input scalar values.
		/// </summary>
		// Token: 0x060177A2 RID: 96162 RVA: 0x0020F214 File Offset: 0x0020D414
		public virtual int GetGenerateTCoordsMaxValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetGenerateTCoordsMaxValue_03(base.GetCppThis());
		}

		// Token: 0x060177A3 RID: 96163
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineFilter_GetGenerateTCoordsMinValue_04(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the output polyline. The texture coordinates
		/// can be generated in three ways: a normalized (0,1) generation;
		/// based on the length (divided by the texture length); and by using
		/// the input scalar values.
		/// </summary>
		// Token: 0x060177A4 RID: 96164 RVA: 0x0020F234 File Offset: 0x0020D434
		public virtual int GetGenerateTCoordsMinValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetGenerateTCoordsMinValue_04(base.GetCppThis());
		}

		// Token: 0x060177A5 RID: 96165
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSplineFilter_GetLength_05(HandleRef pThis);

		/// <summary>
		/// Control the number of subdivisions that are created for the
		/// polyline based on an absolute length. The length of the spline
		/// is divided by this length to determine the number of subdivisions.
		/// </summary>
		// Token: 0x060177A6 RID: 96166 RVA: 0x0020F254 File Offset: 0x0020D454
		public virtual double GetLength()
		{
			return vtkSplineFilter.vtkSplineFilter_GetLength_05(base.GetCppThis());
		}

		// Token: 0x060177A7 RID: 96167
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSplineFilter_GetLengthMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Control the number of subdivisions that are created for the
		/// polyline based on an absolute length. The length of the spline
		/// is divided by this length to determine the number of subdivisions.
		/// </summary>
		// Token: 0x060177A8 RID: 96168 RVA: 0x0020F274 File Offset: 0x0020D474
		public virtual double GetLengthMaxValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetLengthMaxValue_06(base.GetCppThis());
		}

		// Token: 0x060177A9 RID: 96169
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSplineFilter_GetLengthMinValue_07(HandleRef pThis);

		/// <summary>
		/// Control the number of subdivisions that are created for the
		/// polyline based on an absolute length. The length of the spline
		/// is divided by this length to determine the number of subdivisions.
		/// </summary>
		// Token: 0x060177AA RID: 96170 RVA: 0x0020F294 File Offset: 0x0020D494
		public virtual double GetLengthMinValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetLengthMinValue_07(base.GetCppThis());
		}

		// Token: 0x060177AB RID: 96171
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineFilter_GetMaximumNumberOfSubdivisions_08(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of subdivisions that are created for each
		/// polyline.
		/// </summary>
		// Token: 0x060177AC RID: 96172 RVA: 0x0020F2B4 File Offset: 0x0020D4B4
		public virtual int GetMaximumNumberOfSubdivisions()
		{
			return vtkSplineFilter.vtkSplineFilter_GetMaximumNumberOfSubdivisions_08(base.GetCppThis());
		}

		// Token: 0x060177AD RID: 96173
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineFilter_GetMaximumNumberOfSubdivisionsMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of subdivisions that are created for each
		/// polyline.
		/// </summary>
		// Token: 0x060177AE RID: 96174 RVA: 0x0020F2D4 File Offset: 0x0020D4D4
		public virtual int GetMaximumNumberOfSubdivisionsMaxValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetMaximumNumberOfSubdivisionsMaxValue_09(base.GetCppThis());
		}

		// Token: 0x060177AF RID: 96175
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineFilter_GetMaximumNumberOfSubdivisionsMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of subdivisions that are created for each
		/// polyline.
		/// </summary>
		// Token: 0x060177B0 RID: 96176 RVA: 0x0020F2F4 File Offset: 0x0020D4F4
		public virtual int GetMaximumNumberOfSubdivisionsMinValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetMaximumNumberOfSubdivisionsMinValue_10(base.GetCppThis());
		}

		// Token: 0x060177B1 RID: 96177
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplineFilter_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060177B2 RID: 96178 RVA: 0x0020F314 File Offset: 0x0020D514
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSplineFilter.vtkSplineFilter_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x060177B3 RID: 96179
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplineFilter_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060177B4 RID: 96180 RVA: 0x0020F334 File Offset: 0x0020D534
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSplineFilter.vtkSplineFilter_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x060177B5 RID: 96181
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineFilter_GetNumberOfSubdivisions_13(HandleRef pThis);

		/// <summary>
		/// Set the number of subdivisions that are created for the
		/// polyline. This method only has effect if Subdivisions is set
		/// to SetSubdivisionsToSpecify().
		/// </summary>
		// Token: 0x060177B6 RID: 96182 RVA: 0x0020F350 File Offset: 0x0020D550
		public virtual int GetNumberOfSubdivisions()
		{
			return vtkSplineFilter.vtkSplineFilter_GetNumberOfSubdivisions_13(base.GetCppThis());
		}

		// Token: 0x060177B7 RID: 96183
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineFilter_GetNumberOfSubdivisionsMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set the number of subdivisions that are created for the
		/// polyline. This method only has effect if Subdivisions is set
		/// to SetSubdivisionsToSpecify().
		/// </summary>
		// Token: 0x060177B8 RID: 96184 RVA: 0x0020F370 File Offset: 0x0020D570
		public virtual int GetNumberOfSubdivisionsMaxValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetNumberOfSubdivisionsMaxValue_14(base.GetCppThis());
		}

		// Token: 0x060177B9 RID: 96185
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineFilter_GetNumberOfSubdivisionsMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set the number of subdivisions that are created for the
		/// polyline. This method only has effect if Subdivisions is set
		/// to SetSubdivisionsToSpecify().
		/// </summary>
		// Token: 0x060177BA RID: 96186 RVA: 0x0020F390 File Offset: 0x0020D590
		public virtual int GetNumberOfSubdivisionsMinValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetNumberOfSubdivisionsMinValue_15(base.GetCppThis());
		}

		// Token: 0x060177BB RID: 96187
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineFilter_GetSpline_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify an instance of vtkSpline to use to perform the interpolation.
		/// </summary>
		// Token: 0x060177BC RID: 96188 RVA: 0x0020F3B0 File Offset: 0x0020D5B0
		public virtual vtkSpline GetSpline()
		{
			vtkSpline vtkSpline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineFilter.vtkSplineFilter_GetSpline_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpline = (vtkSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpline.Register(null);
				}
			}
			return vtkSpline;
		}

		// Token: 0x060177BD RID: 96189
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineFilter_GetSubdivide_17(HandleRef pThis);

		/// <summary>
		/// Specify how the number of subdivisions is determined.
		/// </summary>
		// Token: 0x060177BE RID: 96190 RVA: 0x0020F420 File Offset: 0x0020D620
		public virtual int GetSubdivide()
		{
			return vtkSplineFilter.vtkSplineFilter_GetSubdivide_17(base.GetCppThis());
		}

		// Token: 0x060177BF RID: 96191
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineFilter_GetSubdivideAsString_18(HandleRef pThis);

		/// <summary>
		/// Specify how the number of subdivisions is determined.
		/// </summary>
		// Token: 0x060177C0 RID: 96192 RVA: 0x0020F440 File Offset: 0x0020D640
		public string GetSubdivideAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkSplineFilter.vtkSplineFilter_GetSubdivideAsString_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060177C1 RID: 96193
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineFilter_GetSubdivideMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Specify how the number of subdivisions is determined.
		/// </summary>
		// Token: 0x060177C2 RID: 96194 RVA: 0x0020F47C File Offset: 0x0020D67C
		public virtual int GetSubdivideMaxValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetSubdivideMaxValue_19(base.GetCppThis());
		}

		// Token: 0x060177C3 RID: 96195
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineFilter_GetSubdivideMinValue_20(HandleRef pThis);

		/// <summary>
		/// Specify how the number of subdivisions is determined.
		/// </summary>
		// Token: 0x060177C4 RID: 96196 RVA: 0x0020F49C File Offset: 0x0020D69C
		public virtual int GetSubdivideMinValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetSubdivideMinValue_20(base.GetCppThis());
		}

		// Token: 0x060177C5 RID: 96197
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSplineFilter_GetTextureLength_21(HandleRef pThis);

		/// <summary>
		/// Control the conversion of units during the texture coordinates
		/// calculation. The TextureLength indicates what length (whether
		/// calculated from scalars or length) is mapped to the [0,1)
		/// texture space.
		/// </summary>
		// Token: 0x060177C6 RID: 96198 RVA: 0x0020F4BC File Offset: 0x0020D6BC
		public virtual double GetTextureLength()
		{
			return vtkSplineFilter.vtkSplineFilter_GetTextureLength_21(base.GetCppThis());
		}

		// Token: 0x060177C7 RID: 96199
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSplineFilter_GetTextureLengthMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Control the conversion of units during the texture coordinates
		/// calculation. The TextureLength indicates what length (whether
		/// calculated from scalars or length) is mapped to the [0,1)
		/// texture space.
		/// </summary>
		// Token: 0x060177C8 RID: 96200 RVA: 0x0020F4DC File Offset: 0x0020D6DC
		public virtual double GetTextureLengthMaxValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetTextureLengthMaxValue_22(base.GetCppThis());
		}

		// Token: 0x060177C9 RID: 96201
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSplineFilter_GetTextureLengthMinValue_23(HandleRef pThis);

		/// <summary>
		/// Control the conversion of units during the texture coordinates
		/// calculation. The TextureLength indicates what length (whether
		/// calculated from scalars or length) is mapped to the [0,1)
		/// texture space.
		/// </summary>
		// Token: 0x060177CA RID: 96202 RVA: 0x0020F4FC File Offset: 0x0020D6FC
		public virtual double GetTextureLengthMinValue()
		{
			return vtkSplineFilter.vtkSplineFilter_GetTextureLengthMinValue_23(base.GetCppThis());
		}

		// Token: 0x060177CB RID: 96203
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineFilter_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060177CC RID: 96204 RVA: 0x0020F51C File Offset: 0x0020D71C
		public override int IsA(string type)
		{
			return vtkSplineFilter.vtkSplineFilter_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x060177CD RID: 96205
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineFilter_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060177CE RID: 96206 RVA: 0x0020F53C File Offset: 0x0020D73C
		public new static int IsTypeOf(string type)
		{
			return vtkSplineFilter.vtkSplineFilter_IsTypeOf_25(type);
		}

		// Token: 0x060177CF RID: 96207
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineFilter_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060177D0 RID: 96208 RVA: 0x0020F558 File Offset: 0x0020D758
		public new vtkSplineFilter NewInstance()
		{
			vtkSplineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineFilter.vtkSplineFilter_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060177D1 RID: 96209
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineFilter_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060177D2 RID: 96210 RVA: 0x0020F5B4 File Offset: 0x0020D7B4
		public new static vtkSplineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSplineFilter vtkSplineFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineFilter.vtkSplineFilter_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSplineFilter = (vtkSplineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSplineFilter.Register(null);
				}
			}
			return vtkSplineFilter;
		}

		// Token: 0x060177D3 RID: 96211
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineFilter_SetGenerateTCoords_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the output polyline. The texture coordinates
		/// can be generated in three ways: a normalized (0,1) generation;
		/// based on the length (divided by the texture length); and by using
		/// the input scalar values.
		/// </summary>
		// Token: 0x060177D4 RID: 96212 RVA: 0x0020F633 File Offset: 0x0020D833
		public virtual void SetGenerateTCoords(int _arg)
		{
			vtkSplineFilter.vtkSplineFilter_SetGenerateTCoords_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060177D5 RID: 96213
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineFilter_SetGenerateTCoordsToNormalizedLength_30(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the output polyline. The texture coordinates
		/// can be generated in three ways: a normalized (0,1) generation;
		/// based on the length (divided by the texture length); and by using
		/// the input scalar values.
		/// </summary>
		// Token: 0x060177D6 RID: 96214 RVA: 0x0020F643 File Offset: 0x0020D843
		public void SetGenerateTCoordsToNormalizedLength()
		{
			vtkSplineFilter.vtkSplineFilter_SetGenerateTCoordsToNormalizedLength_30(base.GetCppThis());
		}

		// Token: 0x060177D7 RID: 96215
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineFilter_SetGenerateTCoordsToOff_31(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the output polyline. The texture coordinates
		/// can be generated in three ways: a normalized (0,1) generation;
		/// based on the length (divided by the texture length); and by using
		/// the input scalar values.
		/// </summary>
		// Token: 0x060177D8 RID: 96216 RVA: 0x0020F652 File Offset: 0x0020D852
		public void SetGenerateTCoordsToOff()
		{
			vtkSplineFilter.vtkSplineFilter_SetGenerateTCoordsToOff_31(base.GetCppThis());
		}

		// Token: 0x060177D9 RID: 96217
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineFilter_SetGenerateTCoordsToUseLength_32(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the output polyline. The texture coordinates
		/// can be generated in three ways: a normalized (0,1) generation;
		/// based on the length (divided by the texture length); and by using
		/// the input scalar values.
		/// </summary>
		// Token: 0x060177DA RID: 96218 RVA: 0x0020F661 File Offset: 0x0020D861
		public void SetGenerateTCoordsToUseLength()
		{
			vtkSplineFilter.vtkSplineFilter_SetGenerateTCoordsToUseLength_32(base.GetCppThis());
		}

		// Token: 0x060177DB RID: 96219
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineFilter_SetGenerateTCoordsToUseScalars_33(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the output polyline. The texture coordinates
		/// can be generated in three ways: a normalized (0,1) generation;
		/// based on the length (divided by the texture length); and by using
		/// the input scalar values.
		/// </summary>
		// Token: 0x060177DC RID: 96220 RVA: 0x0020F670 File Offset: 0x0020D870
		public void SetGenerateTCoordsToUseScalars()
		{
			vtkSplineFilter.vtkSplineFilter_SetGenerateTCoordsToUseScalars_33(base.GetCppThis());
		}

		// Token: 0x060177DD RID: 96221
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineFilter_SetLength_34(HandleRef pThis, double _arg);

		/// <summary>
		/// Control the number of subdivisions that are created for the
		/// polyline based on an absolute length. The length of the spline
		/// is divided by this length to determine the number of subdivisions.
		/// </summary>
		// Token: 0x060177DE RID: 96222 RVA: 0x0020F67F File Offset: 0x0020D87F
		public virtual void SetLength(double _arg)
		{
			vtkSplineFilter.vtkSplineFilter_SetLength_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060177DF RID: 96223
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineFilter_SetMaximumNumberOfSubdivisions_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the maximum number of subdivisions that are created for each
		/// polyline.
		/// </summary>
		// Token: 0x060177E0 RID: 96224 RVA: 0x0020F68F File Offset: 0x0020D88F
		public virtual void SetMaximumNumberOfSubdivisions(int _arg)
		{
			vtkSplineFilter.vtkSplineFilter_SetMaximumNumberOfSubdivisions_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060177E1 RID: 96225
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineFilter_SetNumberOfSubdivisions_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of subdivisions that are created for the
		/// polyline. This method only has effect if Subdivisions is set
		/// to SetSubdivisionsToSpecify().
		/// </summary>
		// Token: 0x060177E2 RID: 96226 RVA: 0x0020F69F File Offset: 0x0020D89F
		public virtual void SetNumberOfSubdivisions(int _arg)
		{
			vtkSplineFilter.vtkSplineFilter_SetNumberOfSubdivisions_36(base.GetCppThis(), _arg);
		}

		// Token: 0x060177E3 RID: 96227
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineFilter_SetSpline_37(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify an instance of vtkSpline to use to perform the interpolation.
		/// </summary>
		// Token: 0x060177E4 RID: 96228 RVA: 0x0020F6B0 File Offset: 0x0020D8B0
		public virtual void SetSpline(vtkSpline arg0)
		{
			vtkSplineFilter.vtkSplineFilter_SetSpline_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060177E5 RID: 96229
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineFilter_SetSubdivide_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify how the number of subdivisions is determined.
		/// </summary>
		// Token: 0x060177E6 RID: 96230 RVA: 0x0020F6DF File Offset: 0x0020D8DF
		public virtual void SetSubdivide(int _arg)
		{
			vtkSplineFilter.vtkSplineFilter_SetSubdivide_38(base.GetCppThis(), _arg);
		}

		// Token: 0x060177E7 RID: 96231
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineFilter_SetSubdivideToLength_39(HandleRef pThis);

		/// <summary>
		/// Specify how the number of subdivisions is determined.
		/// </summary>
		// Token: 0x060177E8 RID: 96232 RVA: 0x0020F6EF File Offset: 0x0020D8EF
		public void SetSubdivideToLength()
		{
			vtkSplineFilter.vtkSplineFilter_SetSubdivideToLength_39(base.GetCppThis());
		}

		// Token: 0x060177E9 RID: 96233
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineFilter_SetSubdivideToSpecified_40(HandleRef pThis);

		/// <summary>
		/// Specify how the number of subdivisions is determined.
		/// </summary>
		// Token: 0x060177EA RID: 96234 RVA: 0x0020F6FE File Offset: 0x0020D8FE
		public void SetSubdivideToSpecified()
		{
			vtkSplineFilter.vtkSplineFilter_SetSubdivideToSpecified_40(base.GetCppThis());
		}

		// Token: 0x060177EB RID: 96235
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineFilter_SetTextureLength_41(HandleRef pThis, double _arg);

		/// <summary>
		/// Control the conversion of units during the texture coordinates
		/// calculation. The TextureLength indicates what length (whether
		/// calculated from scalars or length) is mapped to the [0,1)
		/// texture space.
		/// </summary>
		// Token: 0x060177EC RID: 96236 RVA: 0x0020F70D File Offset: 0x0020D90D
		public virtual void SetTextureLength(double _arg)
		{
			vtkSplineFilter.vtkSplineFilter_SetTextureLength_41(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A37 RID: 6711
		public new const string MRFullTypeName = "Kitware.VTK.vtkSplineFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A38 RID: 6712
		public new static readonly string MRClassNameKey = "class vtkSplineFilter";
	}
}
