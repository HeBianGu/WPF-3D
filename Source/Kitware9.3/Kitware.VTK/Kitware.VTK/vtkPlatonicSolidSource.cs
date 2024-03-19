using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlatonicSolidSource
	/// </summary>
	/// <remarks>
	///    produce polygonal Platonic solids
	///
	/// vtkPlatonicSolidSource can generate each of the five Platonic solids:
	/// tetrahedron, cube, octahedron, icosahedron, and dodecahedron. Each of the
	/// solids is placed inside a sphere centered at the origin with radius 1.0.
	/// To use this class, simply specify the solid to create. Note that this
	/// source object creates cell scalars that are (integral value) face numbers.
	/// </remarks>
	// Token: 0x02000836 RID: 2102
	public class vtkPlatonicSolidSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015C0E RID: 89102 RVA: 0x001EB15A File Offset: 0x001E935A
		static vtkPlatonicSolidSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlatonicSolidSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlatonicSolidSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015C0F RID: 89103 RVA: 0x001EB182 File Offset: 0x001E9382
		public vtkPlatonicSolidSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015C10 RID: 89104
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlatonicSolidSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C11 RID: 89105 RVA: 0x001EB190 File Offset: 0x001E9390
		public new static vtkPlatonicSolidSource New()
		{
			vtkPlatonicSolidSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlatonicSolidSource.vtkPlatonicSolidSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlatonicSolidSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C12 RID: 89106 RVA: 0x001EB1E4 File Offset: 0x001E93E4
		public vtkPlatonicSolidSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlatonicSolidSource.vtkPlatonicSolidSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015C13 RID: 89107 RVA: 0x001EB228 File Offset: 0x001E9428
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015C14 RID: 89108
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlatonicSolidSource_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C15 RID: 89109 RVA: 0x001EB234 File Offset: 0x001E9434
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlatonicSolidSource.vtkPlatonicSolidSource_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06015C16 RID: 89110
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlatonicSolidSource_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C17 RID: 89111 RVA: 0x001EB254 File Offset: 0x001E9454
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlatonicSolidSource.vtkPlatonicSolidSource_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06015C18 RID: 89112
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlatonicSolidSource_GetOutputPointsPrecision_03(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015C19 RID: 89113 RVA: 0x001EB270 File Offset: 0x001E9470
		public virtual int GetOutputPointsPrecision()
		{
			return vtkPlatonicSolidSource.vtkPlatonicSolidSource_GetOutputPointsPrecision_03(base.GetCppThis());
		}

		// Token: 0x06015C1A RID: 89114
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlatonicSolidSource_GetSolidType_04(HandleRef pThis);

		/// <summary>
		/// Specify the type of PlatonicSolid solid to create.
		/// </summary>
		// Token: 0x06015C1B RID: 89115 RVA: 0x001EB290 File Offset: 0x001E9490
		public virtual int GetSolidType()
		{
			return vtkPlatonicSolidSource.vtkPlatonicSolidSource_GetSolidType_04(base.GetCppThis());
		}

		// Token: 0x06015C1C RID: 89116
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlatonicSolidSource_GetSolidTypeMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Specify the type of PlatonicSolid solid to create.
		/// </summary>
		// Token: 0x06015C1D RID: 89117 RVA: 0x001EB2B0 File Offset: 0x001E94B0
		public virtual int GetSolidTypeMaxValue()
		{
			return vtkPlatonicSolidSource.vtkPlatonicSolidSource_GetSolidTypeMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06015C1E RID: 89118
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlatonicSolidSource_GetSolidTypeMinValue_06(HandleRef pThis);

		/// <summary>
		/// Specify the type of PlatonicSolid solid to create.
		/// </summary>
		// Token: 0x06015C1F RID: 89119 RVA: 0x001EB2D0 File Offset: 0x001E94D0
		public virtual int GetSolidTypeMinValue()
		{
			return vtkPlatonicSolidSource.vtkPlatonicSolidSource_GetSolidTypeMinValue_06(base.GetCppThis());
		}

		// Token: 0x06015C20 RID: 89120
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlatonicSolidSource_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C21 RID: 89121 RVA: 0x001EB2F0 File Offset: 0x001E94F0
		public override int IsA(string type)
		{
			return vtkPlatonicSolidSource.vtkPlatonicSolidSource_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06015C22 RID: 89122
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlatonicSolidSource_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C23 RID: 89123 RVA: 0x001EB310 File Offset: 0x001E9510
		public new static int IsTypeOf(string type)
		{
			return vtkPlatonicSolidSource.vtkPlatonicSolidSource_IsTypeOf_08(type);
		}

		// Token: 0x06015C24 RID: 89124
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlatonicSolidSource_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C25 RID: 89125 RVA: 0x001EB32C File Offset: 0x001E952C
		public new vtkPlatonicSolidSource NewInstance()
		{
			vtkPlatonicSolidSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlatonicSolidSource.vtkPlatonicSolidSource_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlatonicSolidSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015C26 RID: 89126
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlatonicSolidSource_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C27 RID: 89127 RVA: 0x001EB388 File Offset: 0x001E9588
		public new static vtkPlatonicSolidSource SafeDownCast(vtkObjectBase o)
		{
			vtkPlatonicSolidSource vtkPlatonicSolidSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlatonicSolidSource.vtkPlatonicSolidSource_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlatonicSolidSource = (vtkPlatonicSolidSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlatonicSolidSource.Register(null);
				}
			}
			return vtkPlatonicSolidSource;
		}

		// Token: 0x06015C28 RID: 89128
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlatonicSolidSource_SetOutputPointsPrecision_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015C29 RID: 89129 RVA: 0x001EB407 File Offset: 0x001E9607
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkPlatonicSolidSource.vtkPlatonicSolidSource_SetOutputPointsPrecision_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06015C2A RID: 89130
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlatonicSolidSource_SetSolidType_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the type of PlatonicSolid solid to create.
		/// </summary>
		// Token: 0x06015C2B RID: 89131 RVA: 0x001EB417 File Offset: 0x001E9617
		public virtual void SetSolidType(int _arg)
		{
			vtkPlatonicSolidSource.vtkPlatonicSolidSource_SetSolidType_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06015C2C RID: 89132
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlatonicSolidSource_SetSolidTypeToCube_14(HandleRef pThis);

		/// <summary>
		/// Specify the type of PlatonicSolid solid to create.
		/// </summary>
		// Token: 0x06015C2D RID: 89133 RVA: 0x001EB427 File Offset: 0x001E9627
		public void SetSolidTypeToCube()
		{
			vtkPlatonicSolidSource.vtkPlatonicSolidSource_SetSolidTypeToCube_14(base.GetCppThis());
		}

		// Token: 0x06015C2E RID: 89134
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlatonicSolidSource_SetSolidTypeToDodecahedron_15(HandleRef pThis);

		/// <summary>
		/// Specify the type of PlatonicSolid solid to create.
		/// </summary>
		// Token: 0x06015C2F RID: 89135 RVA: 0x001EB436 File Offset: 0x001E9636
		public void SetSolidTypeToDodecahedron()
		{
			vtkPlatonicSolidSource.vtkPlatonicSolidSource_SetSolidTypeToDodecahedron_15(base.GetCppThis());
		}

		// Token: 0x06015C30 RID: 89136
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlatonicSolidSource_SetSolidTypeToIcosahedron_16(HandleRef pThis);

		/// <summary>
		/// Specify the type of PlatonicSolid solid to create.
		/// </summary>
		// Token: 0x06015C31 RID: 89137 RVA: 0x001EB445 File Offset: 0x001E9645
		public void SetSolidTypeToIcosahedron()
		{
			vtkPlatonicSolidSource.vtkPlatonicSolidSource_SetSolidTypeToIcosahedron_16(base.GetCppThis());
		}

		// Token: 0x06015C32 RID: 89138
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlatonicSolidSource_SetSolidTypeToOctahedron_17(HandleRef pThis);

		/// <summary>
		/// Specify the type of PlatonicSolid solid to create.
		/// </summary>
		// Token: 0x06015C33 RID: 89139 RVA: 0x001EB454 File Offset: 0x001E9654
		public void SetSolidTypeToOctahedron()
		{
			vtkPlatonicSolidSource.vtkPlatonicSolidSource_SetSolidTypeToOctahedron_17(base.GetCppThis());
		}

		// Token: 0x06015C34 RID: 89140
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlatonicSolidSource_SetSolidTypeToTetrahedron_18(HandleRef pThis);

		/// <summary>
		/// Specify the type of PlatonicSolid solid to create.
		/// </summary>
		// Token: 0x06015C35 RID: 89141 RVA: 0x001EB463 File Offset: 0x001E9663
		public void SetSolidTypeToTetrahedron()
		{
			vtkPlatonicSolidSource.vtkPlatonicSolidSource_SetSolidTypeToTetrahedron_18(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018C3 RID: 6339
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlatonicSolidSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018C4 RID: 6340
		public new static readonly string MRClassNameKey = "class vtkPlatonicSolidSource";
	}
}
