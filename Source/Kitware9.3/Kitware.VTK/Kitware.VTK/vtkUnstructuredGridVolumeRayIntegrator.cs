using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridVolumeRayIntegrator
	/// </summary>
	/// <remarks>
	///    a superclass for volume ray integration functions
	///
	///
	///
	/// vtkUnstructuredGridVolumeRayIntegrator is a superclass for ray
	/// integration functions that can be used within a
	/// vtkUnstructuredGridVolumeRayCastMapper.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkUnstructuredGridVolumeRayCastMapper
	/// vtkUnstructuredGridVolumeRayCastFunction
	/// </seealso>
	// Token: 0x020003A4 RID: 932
	public abstract class vtkUnstructuredGridVolumeRayIntegrator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A97E RID: 43390 RVA: 0x000F0D3F File Offset: 0x000EEF3F
		static vtkUnstructuredGridVolumeRayIntegrator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridVolumeRayIntegrator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeRayIntegrator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A97F RID: 43391 RVA: 0x000F0D67 File Offset: 0x000EEF67
		public vtkUnstructuredGridVolumeRayIntegrator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A980 RID: 43392 RVA: 0x000F0D75 File Offset: 0x000EEF75
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A981 RID: 43393
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridVolumeRayIntegrator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A982 RID: 43394 RVA: 0x000F0D80 File Offset: 0x000EEF80
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridVolumeRayIntegrator.vtkUnstructuredGridVolumeRayIntegrator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600A983 RID: 43395
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridVolumeRayIntegrator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A984 RID: 43396 RVA: 0x000F0DA0 File Offset: 0x000EEFA0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridVolumeRayIntegrator.vtkUnstructuredGridVolumeRayIntegrator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600A985 RID: 43397
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayIntegrator_Initialize_03(HandleRef pThis, HandleRef volume, HandleRef scalars);

		/// <summary>
		/// Set up the integrator with the given properties and scalars.
		/// </summary>
		// Token: 0x0600A986 RID: 43398 RVA: 0x000F0DBC File Offset: 0x000EEFBC
		public virtual void Initialize(vtkVolume volume, vtkDataArray scalars)
		{
			vtkUnstructuredGridVolumeRayIntegrator.vtkUnstructuredGridVolumeRayIntegrator_Initialize_03(base.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis());
		}

		// Token: 0x0600A987 RID: 43399
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayIntegrator_Integrate_04(HandleRef pThis, HandleRef intersectionLengths, HandleRef nearIntersections, HandleRef farIntersections, IntPtr color);

		/// <summary>
		/// Given a set of intersections (defined by the three arrays), compute
		/// the piecewise integration of the array in front to back order.
		/// /c intersectionLengths holds the lengths of each piecewise segment.
		/// /c nearIntersections and /c farIntersections hold the scalar values at
		/// the front and back of each segment.  /c color should contain the RGBA
		/// value of the volume in front of the segments passed in, and the result
		/// will be placed back into /c color.
		/// </summary>
		// Token: 0x0600A988 RID: 43400 RVA: 0x000F0E00 File Offset: 0x000EF000
		public virtual void Integrate(vtkDoubleArray intersectionLengths, vtkDataArray nearIntersections, vtkDataArray farIntersections, IntPtr color)
		{
			vtkUnstructuredGridVolumeRayIntegrator.vtkUnstructuredGridVolumeRayIntegrator_Integrate_04(base.GetCppThis(), (intersectionLengths == null) ? default(HandleRef) : intersectionLengths.GetCppThis(), (nearIntersections == null) ? default(HandleRef) : nearIntersections.GetCppThis(), (farIntersections == null) ? default(HandleRef) : farIntersections.GetCppThis(), color);
		}

		// Token: 0x0600A989 RID: 43401
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeRayIntegrator_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A98A RID: 43402 RVA: 0x000F0E5C File Offset: 0x000EF05C
		public override int IsA(string type)
		{
			return vtkUnstructuredGridVolumeRayIntegrator.vtkUnstructuredGridVolumeRayIntegrator_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600A98B RID: 43403
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeRayIntegrator_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A98C RID: 43404 RVA: 0x000F0E7C File Offset: 0x000EF07C
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridVolumeRayIntegrator.vtkUnstructuredGridVolumeRayIntegrator_IsTypeOf_06(type);
		}

		// Token: 0x0600A98D RID: 43405
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayIntegrator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A98E RID: 43406 RVA: 0x000F0E98 File Offset: 0x000EF098
		public new vtkUnstructuredGridVolumeRayIntegrator NewInstance()
		{
			vtkUnstructuredGridVolumeRayIntegrator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayIntegrator.vtkUnstructuredGridVolumeRayIntegrator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeRayIntegrator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A98F RID: 43407
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayIntegrator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A990 RID: 43408 RVA: 0x000F0EF4 File Offset: 0x000EF0F4
		public new static vtkUnstructuredGridVolumeRayIntegrator SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridVolumeRayIntegrator vtkUnstructuredGridVolumeRayIntegrator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayIntegrator.vtkUnstructuredGridVolumeRayIntegrator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayIntegrator = (vtkUnstructuredGridVolumeRayIntegrator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayIntegrator.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayIntegrator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D7D RID: 3453
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeRayIntegrator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D7E RID: 3454
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridVolumeRayIntegrator";
	}
}
