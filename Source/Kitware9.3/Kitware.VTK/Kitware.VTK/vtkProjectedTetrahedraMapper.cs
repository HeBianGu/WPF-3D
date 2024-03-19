using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProjectedTetrahedraMapper
	/// </summary>
	/// <remarks>
	///    Unstructured grid volume renderer.
	///
	///
	/// vtkProjectedTetrahedraMapper is an implementation of the classic
	/// Projected Tetrahedra algorithm presented by Shirley and Tuchman in "A
	/// Polygonal Approximation to Direct Scalar Volume Rendering" in Computer
	/// Graphics, December 1990.
	///
	/// @bug
	/// This mapper relies highly on the implementation of the OpenGL pipeline.
	/// A typical hardware driver has lots of options and some settings can
	/// cause this mapper to produce artifacts.
	///
	/// </remarks>
	// Token: 0x020000D8 RID: 216
	public abstract class vtkProjectedTetrahedraMapper : vtkUnstructuredGridVolumeMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002DBD RID: 11709 RVA: 0x00043049 File Offset: 0x00041249
		static vtkProjectedTetrahedraMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProjectedTetrahedraMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProjectedTetrahedraMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002DBE RID: 11710 RVA: 0x00043071 File Offset: 0x00041271
		public vtkProjectedTetrahedraMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002DBF RID: 11711
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTetrahedraMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DC0 RID: 11712 RVA: 0x00043080 File Offset: 0x00041280
		public new static vtkProjectedTetrahedraMapper New()
		{
			vtkProjectedTetrahedraMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DC1 RID: 11713 RVA: 0x000430D4 File Offset: 0x000412D4
		public vtkProjectedTetrahedraMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002DC2 RID: 11714 RVA: 0x00043118 File Offset: 0x00041318
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002DC3 RID: 11715
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProjectedTetrahedraMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DC4 RID: 11716 RVA: 0x00043124 File Offset: 0x00041324
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06002DC5 RID: 11717
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProjectedTetrahedraMapper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DC6 RID: 11718 RVA: 0x00043144 File Offset: 0x00041344
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06002DC7 RID: 11719
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTetrahedraMapper_GetVisibilitySort_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DC8 RID: 11720 RVA: 0x00043160 File Offset: 0x00041360
		public virtual vtkVisibilitySort GetVisibilitySort()
		{
			vtkVisibilitySort vtkVisibilitySort = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_GetVisibilitySort_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVisibilitySort = (vtkVisibilitySort)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVisibilitySort.Register(null);
				}
			}
			return vtkVisibilitySort;
		}

		// Token: 0x06002DC9 RID: 11721
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectedTetrahedraMapper_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DCA RID: 11722 RVA: 0x000431D0 File Offset: 0x000413D0
		public override int IsA(string type)
		{
			return vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06002DCB RID: 11723
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProjectedTetrahedraMapper_IsSupported_05(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Return true if the rendering context provides
		/// the nececessary functionality to use this class.
		/// </summary>
		// Token: 0x06002DCC RID: 11724 RVA: 0x000431F0 File Offset: 0x000413F0
		public virtual bool IsSupported(vtkRenderWindow arg0)
		{
			return vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_IsSupported_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis()) != 0;
		}

		// Token: 0x06002DCD RID: 11725
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectedTetrahedraMapper_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DCE RID: 11726 RVA: 0x0004322C File Offset: 0x0004142C
		public new static int IsTypeOf(string type)
		{
			return vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_IsTypeOf_06(type);
		}

		// Token: 0x06002DCF RID: 11727
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTetrahedraMapper_MapScalarsToColors_07(HandleRef colors, HandleRef property, HandleRef scalars);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DD0 RID: 11728 RVA: 0x00043248 File Offset: 0x00041448
		public static void MapScalarsToColors(vtkDataArray colors, vtkVolumeProperty property, vtkDataArray scalars)
		{
			vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_MapScalarsToColors_07((colors == null) ? default(HandleRef) : colors.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis());
		}

		// Token: 0x06002DD1 RID: 11729
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTetrahedraMapper_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DD2 RID: 11730 RVA: 0x0004329C File Offset: 0x0004149C
		public new vtkProjectedTetrahedraMapper NewInstance()
		{
			vtkProjectedTetrahedraMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002DD3 RID: 11731
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTetrahedraMapper_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DD4 RID: 11732 RVA: 0x000432F8 File Offset: 0x000414F8
		public new static vtkProjectedTetrahedraMapper SafeDownCast(vtkObjectBase o)
		{
			vtkProjectedTetrahedraMapper vtkProjectedTetrahedraMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProjectedTetrahedraMapper = (vtkProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProjectedTetrahedraMapper.Register(null);
				}
			}
			return vtkProjectedTetrahedraMapper;
		}

		// Token: 0x06002DD5 RID: 11733
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTetrahedraMapper_SetVisibilitySort_11(HandleRef pThis, HandleRef sort);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DD6 RID: 11734 RVA: 0x00043378 File Offset: 0x00041578
		public virtual void SetVisibilitySort(vtkVisibilitySort sort)
		{
			vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_SetVisibilitySort_11(base.GetCppThis(), (sort == null) ? default(HandleRef) : sort.GetCppThis());
		}

		// Token: 0x06002DD7 RID: 11735
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTetrahedraMapper_TransformPoints_12(HandleRef inPoints, IntPtr projection_mat, IntPtr modelview_mat, HandleRef outPoints);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002DD8 RID: 11736 RVA: 0x000433A8 File Offset: 0x000415A8
		public static void TransformPoints(vtkPoints inPoints, IntPtr projection_mat, IntPtr modelview_mat, vtkFloatArray outPoints)
		{
			vtkProjectedTetrahedraMapper.vtkProjectedTetrahedraMapper_TransformPoints_12((inPoints == null) ? default(HandleRef) : inPoints.GetCppThis(), projection_mat, modelview_mat, (outPoints == null) ? default(HandleRef) : outPoints.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005AC RID: 1452
		public new const string MRFullTypeName = "Kitware.VTK.vtkProjectedTetrahedraMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005AD RID: 1453
		public new static readonly string MRClassNameKey = "class vtkProjectedTetrahedraMapper";
	}
}
