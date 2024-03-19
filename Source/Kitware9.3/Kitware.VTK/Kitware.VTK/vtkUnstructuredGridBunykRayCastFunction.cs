using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridBunykRayCastFunction
	/// </summary>
	/// <remarks>
	///    a superclass for ray casting functions
	///
	///
	/// vtkUnstructuredGridBunykRayCastFunction is a concrete implementation of a
	/// ray cast function for unstructured grid data. This class was based on the
	/// paper "Simple, Fast, Robust Ray Casting of Irregular Grids" by Paul Bunyk,
	/// Arie Kaufmna, and Claudio Silva. This method is quite memory intensive
	/// (with extra explicit copies of the data) and therefore should not be used
	/// for very large data. This method assumes that the input data is composed
	/// entirely of tetras - use vtkDataSetTriangleFilter before setting the input
	/// on the mapper.
	///
	/// The basic idea of this method is as follows:
	///
	///   1) Enumerate the triangles. At each triangle have space for some
	///      information that will be used during rendering. This includes
	///      which tetra the triangles belong to, the plane equation and the
	///      Barycentric coefficients.
	///
	///   2) Keep a reference to all four triangles for each tetra.
	///
	///   3) At the beginning of each render, do the precomputation. This
	///      includes creating an array of transformed points (in view
	///      coordinates) and computing the view dependent info per triangle
	///      (plane equations and barycentric coords in view space)
	///
	///   4) Find all front facing boundary triangles (a triangle is on the
	///      boundary if it belongs to only one tetra). For each triangle,
	///      find all pixels in the image that intersect the triangle, and
	///      add this to the sorted (by depth) intersection list at each
	///      pixel.
	///
	///   5) For each ray cast, traverse the intersection list. At each
	///      intersection, accumulate opacity and color contribution
	///      per tetra along the ray until you reach an exiting triangle
	///      (on the boundary).
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkUnstructuredGridVolumeRayCastMapper
	/// </seealso>
	// Token: 0x020003A3 RID: 931
	public class vtkUnstructuredGridBunykRayCastFunction : vtkUnstructuredGridVolumeRayCastFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A95A RID: 43354 RVA: 0x000F090B File Offset: 0x000EEB0B
		static vtkUnstructuredGridBunykRayCastFunction()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridBunykRayCastFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridBunykRayCastFunction"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A95B RID: 43355 RVA: 0x000F0933 File Offset: 0x000EEB33
		public vtkUnstructuredGridBunykRayCastFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A95C RID: 43356
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A95D RID: 43357 RVA: 0x000F0944 File Offset: 0x000EEB44
		public new static vtkUnstructuredGridBunykRayCastFunction New()
		{
			vtkUnstructuredGridBunykRayCastFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridBunykRayCastFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A95E RID: 43358 RVA: 0x000F0998 File Offset: 0x000EEB98
		public vtkUnstructuredGridBunykRayCastFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A95F RID: 43359 RVA: 0x000F09DC File Offset: 0x000EEBDC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A960 RID: 43360
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridBunykRayCastFunction_Finalize_01(HandleRef pThis);

		/// <summary>
		/// Called by the ray cast mapper at the end of rendering
		/// </summary>
		// Token: 0x0600A961 RID: 43361 RVA: 0x000F09E7 File Offset: 0x000EEBE7
		public override void FinalizeWrapper()
		{
			vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_Finalize_01(base.GetCppThis());
		}

		// Token: 0x0600A962 RID: 43362
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_GetImageOrigin_02(HandleRef pThis);

		/// <summary>
		/// Access to an internal structure for the templated method.
		/// </summary>
		// Token: 0x0600A963 RID: 43363 RVA: 0x000F09F8 File Offset: 0x000EEBF8
		public virtual int[] GetImageOrigin()
		{
			IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_GetImageOrigin_02(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A964 RID: 43364
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridBunykRayCastFunction_GetImageOrigin_03(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Access to an internal structure for the templated method.
		/// </summary>
		// Token: 0x0600A965 RID: 43365 RVA: 0x000F0A40 File Offset: 0x000EEC40
		public virtual void GetImageOrigin(IntPtr data)
		{
			vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_GetImageOrigin_03(base.GetCppThis(), data);
		}

		// Token: 0x0600A966 RID: 43366
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_GetImageViewportSize_04(HandleRef pThis);

		/// <summary>
		/// Access to an internal structure for the templated method.
		/// </summary>
		// Token: 0x0600A967 RID: 43367 RVA: 0x000F0A50 File Offset: 0x000EEC50
		public virtual int[] GetImageViewportSize()
		{
			IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_GetImageViewportSize_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A968 RID: 43368
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridBunykRayCastFunction_GetImageViewportSize_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Access to an internal structure for the templated method.
		/// </summary>
		// Token: 0x0600A969 RID: 43369 RVA: 0x000F0A98 File Offset: 0x000EEC98
		public virtual void GetImageViewportSize(IntPtr data)
		{
			vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_GetImageViewportSize_05(base.GetCppThis(), data);
		}

		// Token: 0x0600A96A RID: 43370
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridBunykRayCastFunction_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A96B RID: 43371 RVA: 0x000F0AA8 File Offset: 0x000EECA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600A96C RID: 43372
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridBunykRayCastFunction_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A96D RID: 43373 RVA: 0x000F0AC8 File Offset: 0x000EECC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600A96E RID: 43374
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_GetPoints_08(HandleRef pThis);

		/// <summary>
		/// Access to an internal structure for the templated method.
		/// </summary>
		// Token: 0x0600A96F RID: 43375 RVA: 0x000F0AE4 File Offset: 0x000EECE4
		public IntPtr GetPoints()
		{
			return vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_GetPoints_08(base.GetCppThis());
		}

		// Token: 0x0600A970 RID: 43376
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_GetViewToWorldMatrix_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access to an internal structure for the templated method.
		/// </summary>
		// Token: 0x0600A971 RID: 43377 RVA: 0x000F0B04 File Offset: 0x000EED04
		public virtual vtkMatrix4x4 GetViewToWorldMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_GetViewToWorldMatrix_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x0600A972 RID: 43378
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridBunykRayCastFunction_Initialize_10(HandleRef pThis, HandleRef ren, HandleRef vol);

		/// <summary>
		/// Called by the ray cast mapper at the start of rendering
		/// </summary>
		// Token: 0x0600A973 RID: 43379 RVA: 0x000F0B74 File Offset: 0x000EED74
		public override void Initialize(vtkRenderer ren, vtkVolume vol)
		{
			vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_Initialize_10(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x0600A974 RID: 43380
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridBunykRayCastFunction_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A975 RID: 43381 RVA: 0x000F0BB8 File Offset: 0x000EEDB8
		public override int IsA(string type)
		{
			return vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600A976 RID: 43382
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridBunykRayCastFunction_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A977 RID: 43383 RVA: 0x000F0BD8 File Offset: 0x000EEDD8
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_IsTypeOf_12(type);
		}

		// Token: 0x0600A978 RID: 43384
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A979 RID: 43385 RVA: 0x000F0BF4 File Offset: 0x000EEDF4
		public new vtkUnstructuredGridBunykRayCastFunction NewInstance()
		{
			vtkUnstructuredGridBunykRayCastFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridBunykRayCastFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A97A RID: 43386
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_NewIterator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Called by the ray cast mapper at the end of rendering
		/// </summary>
		// Token: 0x0600A97B RID: 43387 RVA: 0x000F0C50 File Offset: 0x000EEE50
		public override vtkUnstructuredGridVolumeRayCastIterator NewIterator()
		{
			vtkUnstructuredGridVolumeRayCastIterator vtkUnstructuredGridVolumeRayCastIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_NewIterator_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayCastIterator = (vtkUnstructuredGridVolumeRayCastIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayCastIterator.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayCastIterator;
		}

		// Token: 0x0600A97C RID: 43388
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBunykRayCastFunction_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A97D RID: 43389 RVA: 0x000F0CC0 File Offset: 0x000EEEC0
		public new static vtkUnstructuredGridBunykRayCastFunction SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridBunykRayCastFunction vtkUnstructuredGridBunykRayCastFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridBunykRayCastFunction.vtkUnstructuredGridBunykRayCastFunction_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridBunykRayCastFunction = (vtkUnstructuredGridBunykRayCastFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridBunykRayCastFunction.Register(null);
				}
			}
			return vtkUnstructuredGridBunykRayCastFunction;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D7B RID: 3451
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridBunykRayCastFunction";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D7C RID: 3452
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridBunykRayCastFunction";
	}
}
