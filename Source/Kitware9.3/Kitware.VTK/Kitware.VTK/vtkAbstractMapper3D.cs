using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractMapper3D
	/// </summary>
	/// <remarks>
	///    abstract class specifies interface to map 3D data
	///
	/// vtkAbstractMapper3D is an abstract class to specify interface between 3D
	/// data and graphics primitives or software rendering techniques. Subclasses
	/// of vtkAbstractMapper3D can be used for rendering geometry or rendering
	/// volumetric data.
	///
	/// This class also defines an API to support hardware clipping planes (at most
	/// six planes can be defined). It also provides geometric data about the input
	/// data it maps, such as the bounding box and center.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractMapper vtkMapper vtkPolyDataMapper vtkVolumeMapper
	/// </seealso>
	// Token: 0x020000CB RID: 203
	public abstract class vtkAbstractMapper3D : vtkAbstractMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002B6B RID: 11115 RVA: 0x000403A3 File Offset: 0x0003E5A3
		static vtkAbstractMapper3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractMapper3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractMapper3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002B6C RID: 11116 RVA: 0x000403CB File Offset: 0x0003E5CB
		public vtkAbstractMapper3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002B6D RID: 11117 RVA: 0x000403D9 File Offset: 0x0003E5D9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002B6E RID: 11118
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractMapper3D_GetBounds_01(HandleRef pThis);

		/// <summary>
		/// Return bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// Update this-&gt;Bounds as a side effect.
		/// </summary>
		// Token: 0x06002B6F RID: 11119 RVA: 0x000403E4 File Offset: 0x0003E5E4
		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkAbstractMapper3D.vtkAbstractMapper3D_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002B70 RID: 11120
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractMapper3D_GetBounds_02(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds for this mapper as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// </summary>
		// Token: 0x06002B71 RID: 11121 RVA: 0x0004042C File Offset: 0x0003E62C
		public virtual void GetBounds(IntPtr bounds)
		{
			vtkAbstractMapper3D.vtkAbstractMapper3D_GetBounds_02(base.GetCppThis(), bounds);
		}

		// Token: 0x06002B72 RID: 11122
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractMapper3D_GetCenter_03(HandleRef pThis);

		/// <summary>
		/// Return the Center of this mapper's data.
		/// </summary>
		// Token: 0x06002B73 RID: 11123 RVA: 0x0004043C File Offset: 0x0003E63C
		public double[] GetCenter()
		{
			IntPtr intPtr = vtkAbstractMapper3D.vtkAbstractMapper3D_GetCenter_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002B74 RID: 11124
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractMapper3D_GetCenter_04(HandleRef pThis, IntPtr center);

		/// <summary>
		/// Return the Center of this mapper's data.
		/// </summary>
		// Token: 0x06002B75 RID: 11125 RVA: 0x00040484 File Offset: 0x0003E684
		public void GetCenter(IntPtr center)
		{
			vtkAbstractMapper3D.vtkAbstractMapper3D_GetCenter_04(base.GetCppThis(), center);
		}

		// Token: 0x06002B76 RID: 11126
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractMapper3D_GetClippingPlaneInDataCoords_05(HandleRef pThis, HandleRef propMatrix, int i, IntPtr planeEquation);

		/// <summary>
		/// Get the ith clipping plane as a homogeneous plane equation.
		/// Use GetNumberOfClippingPlanes to get the number of planes.
		/// </summary>
		// Token: 0x06002B77 RID: 11127 RVA: 0x00040494 File Offset: 0x0003E694
		public void GetClippingPlaneInDataCoords(vtkMatrix4x4 propMatrix, int i, IntPtr planeEquation)
		{
			vtkAbstractMapper3D.vtkAbstractMapper3D_GetClippingPlaneInDataCoords_05(base.GetCppThis(), (propMatrix == null) ? default(HandleRef) : propMatrix.GetCppThis(), i, planeEquation);
		}

		// Token: 0x06002B78 RID: 11128
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAbstractMapper3D_GetLength_06(HandleRef pThis);

		/// <summary>
		/// Return the diagonal length of this mappers bounding box.
		/// </summary>
		// Token: 0x06002B79 RID: 11129 RVA: 0x000404C8 File Offset: 0x0003E6C8
		public double GetLength()
		{
			return vtkAbstractMapper3D.vtkAbstractMapper3D_GetLength_06(base.GetCppThis());
		}

		// Token: 0x06002B7A RID: 11130
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractMapper3D_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B7B RID: 11131 RVA: 0x000404E8 File Offset: 0x0003E6E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractMapper3D.vtkAbstractMapper3D_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06002B7C RID: 11132
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractMapper3D_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B7D RID: 11133 RVA: 0x00040508 File Offset: 0x0003E708
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractMapper3D.vtkAbstractMapper3D_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06002B7E RID: 11134
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractMapper3D_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B7F RID: 11135 RVA: 0x00040524 File Offset: 0x0003E724
		public override int IsA(string type)
		{
			return vtkAbstractMapper3D.vtkAbstractMapper3D_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06002B80 RID: 11136
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractMapper3D_IsARayCastMapper_10(HandleRef pThis);

		/// <summary>
		/// Is this a ray cast mapper? A subclass would return 1 if the
		/// ray caster is needed to generate an image from this mapper.
		/// </summary>
		// Token: 0x06002B81 RID: 11137 RVA: 0x00040544 File Offset: 0x0003E744
		public virtual int IsARayCastMapper()
		{
			return vtkAbstractMapper3D.vtkAbstractMapper3D_IsARayCastMapper_10(base.GetCppThis());
		}

		// Token: 0x06002B82 RID: 11138
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractMapper3D_IsARenderIntoImageMapper_11(HandleRef pThis);

		/// <summary>
		/// Is this a "render into image" mapper? A subclass would return 1 if the
		/// mapper produces an image by rendering into a software image buffer.
		/// </summary>
		// Token: 0x06002B83 RID: 11139 RVA: 0x00040564 File Offset: 0x0003E764
		public virtual int IsARenderIntoImageMapper()
		{
			return vtkAbstractMapper3D.vtkAbstractMapper3D_IsARenderIntoImageMapper_11(base.GetCppThis());
		}

		// Token: 0x06002B84 RID: 11140
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractMapper3D_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B85 RID: 11141 RVA: 0x00040584 File Offset: 0x0003E784
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractMapper3D.vtkAbstractMapper3D_IsTypeOf_12(type);
		}

		// Token: 0x06002B86 RID: 11142
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractMapper3D_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B87 RID: 11143 RVA: 0x000405A0 File Offset: 0x0003E7A0
		public new vtkAbstractMapper3D NewInstance()
		{
			vtkAbstractMapper3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractMapper3D.vtkAbstractMapper3D_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractMapper3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002B88 RID: 11144
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractMapper3D_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B89 RID: 11145 RVA: 0x000405FC File Offset: 0x0003E7FC
		public new static vtkAbstractMapper3D SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractMapper3D vtkAbstractMapper3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractMapper3D.vtkAbstractMapper3D_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractMapper3D = (vtkAbstractMapper3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractMapper3D.Register(null);
				}
			}
			return vtkAbstractMapper3D;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000588 RID: 1416
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractMapper3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000589 RID: 1417
		public new static readonly string MRClassNameKey = "class vtkAbstractMapper3D";
	}
}
