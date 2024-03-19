using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkActor2D
	/// </summary>
	/// <remarks>
	///    a actor that draws 2D data
	///
	/// vtkActor2D is similar to vtkActor, but it is made to be used with two
	/// dimensional images and annotation.  vtkActor2D has a position but does not
	/// use a transformation matrix like vtkActor (see the superclass vtkProp
	/// for information on positioning vtkActor2D).  vtkActor2D has a reference to
	/// a vtkMapper2D object which does the rendering.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkProp  vtkMapper2D vtkProperty2D
	/// </seealso>
	// Token: 0x020003BA RID: 954
	public class vtkActor2D : vtkProp
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600AF4A RID: 44874 RVA: 0x000F82B3 File Offset: 0x000F64B3
		static vtkActor2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkActor2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkActor2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600AF4B RID: 44875 RVA: 0x000F82DB File Offset: 0x000F64DB
		public vtkActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600AF4C RID: 44876
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates an actor2D with the following defaults:
		/// position (0,0) (coordinate system is viewport);
		/// at layer 0.
		/// </summary>
		// Token: 0x0600AF4D RID: 44877 RVA: 0x000F82EC File Offset: 0x000F64EC
		public new static vtkActor2D New()
		{
			vtkActor2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2D.vtkActor2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates an actor2D with the following defaults:
		/// position (0,0) (coordinate system is viewport);
		/// at layer 0.
		/// </summary>
		// Token: 0x0600AF4E RID: 44878 RVA: 0x000F8340 File Offset: 0x000F6540
		public vtkActor2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkActor2D.vtkActor2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600AF4F RID: 44879 RVA: 0x000F8384 File Offset: 0x000F6584
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600AF50 RID: 44880
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2D_GetActors2D_01(HandleRef pThis, HandleRef pc);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors or volumes. These methods
		/// are used in that process.
		/// </summary>
		// Token: 0x0600AF51 RID: 44881 RVA: 0x000F8390 File Offset: 0x000F6590
		public override void GetActors2D(vtkPropCollection pc)
		{
			vtkActor2D.vtkActor2D_GetActors2D_01(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		// Token: 0x0600AF52 RID: 44882
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2D_GetActualPosition2Coordinate_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the actual vtkCoordinate reference that the mapper should use
		/// to position the actor. This is used internally by the mappers and should
		/// be overridden in specialized subclasses and otherwise ignored.
		/// </summary>
		// Token: 0x0600AF53 RID: 44883 RVA: 0x000F83C0 File Offset: 0x000F65C0
		public virtual vtkCoordinate GetActualPosition2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetActualPosition2Coordinate_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600AF54 RID: 44884
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2D_GetActualPositionCoordinate_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the actual vtkCoordinate reference that the mapper should use
		/// to position the actor. This is used internally by the mappers and should
		/// be overridden in specialized subclasses and otherwise ignored.
		/// </summary>
		// Token: 0x0600AF55 RID: 44885 RVA: 0x000F8430 File Offset: 0x000F6630
		public virtual vtkCoordinate GetActualPositionCoordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetActualPositionCoordinate_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600AF56 RID: 44886
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkActor2D_GetHeight_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the height and width of the Actor2D. The value is expressed
		/// as a fraction of the viewport. This really is just another way of
		/// setting the Position2 instance variable.
		/// </summary>
		// Token: 0x0600AF57 RID: 44887 RVA: 0x000F84A0 File Offset: 0x000F66A0
		public double GetHeight()
		{
			return vtkActor2D.vtkActor2D_GetHeight_04(base.GetCppThis());
		}

		// Token: 0x0600AF58 RID: 44888
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor2D_GetLayerNumber_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the layer number in the overlay planes into which to render.
		/// </summary>
		// Token: 0x0600AF59 RID: 44889 RVA: 0x000F84C0 File Offset: 0x000F66C0
		public virtual int GetLayerNumber()
		{
			return vtkActor2D.vtkActor2D_GetLayerNumber_05(base.GetCppThis());
		}

		// Token: 0x0600AF5A RID: 44890
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkActor2D_GetMTime_06(HandleRef pThis);

		/// <summary>
		/// Return this objects MTime.
		/// </summary>
		// Token: 0x0600AF5B RID: 44891 RVA: 0x000F84E0 File Offset: 0x000F66E0
		public override ulong GetMTime()
		{
			return vtkActor2D.vtkActor2D_GetMTime_06(base.GetCppThis());
		}

		// Token: 0x0600AF5C RID: 44892
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2D_GetMapper_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the vtkMapper2D which defines the data to be drawn.
		/// </summary>
		// Token: 0x0600AF5D RID: 44893 RVA: 0x000F8500 File Offset: 0x000F6700
		public virtual vtkMapper2D GetMapper()
		{
			vtkMapper2D vtkMapper2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetMapper_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapper2D = (vtkMapper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapper2D.Register(null);
				}
			}
			return vtkMapper2D;
		}

		// Token: 0x0600AF5E RID: 44894
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkActor2D_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AF5F RID: 44895 RVA: 0x000F8570 File Offset: 0x000F6770
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkActor2D.vtkActor2D_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600AF60 RID: 44896
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkActor2D_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AF61 RID: 44897 RVA: 0x000F8590 File Offset: 0x000F6790
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkActor2D.vtkActor2D_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600AF62 RID: 44898
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2D_GetPosition_10(HandleRef pThis);

		/// <summary>
		/// Get the PositionCoordinate instance of vtkCoordinate.
		/// This is used for for complicated or relative positioning.
		/// The position variable controls the lower left corner of the Actor2D
		/// </summary>
		// Token: 0x0600AF63 RID: 44899 RVA: 0x000F85AC File Offset: 0x000F67AC
		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetPosition_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AF64 RID: 44900
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2D_GetPosition2_11(HandleRef pThis);

		/// <summary>
		/// Access the Position2 instance variable. This variable controls
		/// the upper right corner of the Actor2D. It is by default
		/// relative to Position and in normalized viewport coordinates.
		/// Some 2D actor subclasses ignore the position2 variable
		/// </summary>
		// Token: 0x0600AF65 RID: 44901 RVA: 0x000F85F4 File Offset: 0x000F67F4
		public virtual double[] GetPosition2()
		{
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetPosition2_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AF66 RID: 44902
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2D_GetPosition2Coordinate_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the Position2 instance variable. This variable controls
		/// the upper right corner of the Actor2D. It is by default
		/// relative to Position and in normalized viewport coordinates.
		/// Some 2D actor subclasses ignore the position2 variable
		/// </summary>
		// Token: 0x0600AF67 RID: 44903 RVA: 0x000F863C File Offset: 0x000F683C
		public virtual vtkCoordinate GetPosition2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetPosition2Coordinate_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600AF68 RID: 44904
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2D_GetPositionCoordinate_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the PositionCoordinate instance of vtkCoordinate.
		/// This is used for for complicated or relative positioning.
		/// The position variable controls the lower left corner of the Actor2D
		/// </summary>
		// Token: 0x0600AF69 RID: 44905 RVA: 0x000F86AC File Offset: 0x000F68AC
		public virtual vtkCoordinate GetPositionCoordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetPositionCoordinate_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600AF6A RID: 44906
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2D_GetProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns this actor's vtkProperty2D.  Creates a property if one
		/// doesn't already exist.
		/// </summary>
		// Token: 0x0600AF6B RID: 44907 RVA: 0x000F871C File Offset: 0x000F691C
		public vtkProperty2D GetProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2D.vtkActor2D_GetProperty_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x0600AF6C RID: 44908
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkActor2D_GetWidth_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the height and width of the Actor2D. The value is expressed
		/// as a fraction of the viewport. This really is just another way of
		/// setting the Position2 instance variable.
		/// </summary>
		// Token: 0x0600AF6D RID: 44909 RVA: 0x000F878C File Offset: 0x000F698C
		public double GetWidth()
		{
			return vtkActor2D.vtkActor2D_GetWidth_15(base.GetCppThis());
		}

		// Token: 0x0600AF6E RID: 44910
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor2D_HasTranslucentPolygonalGeometry_16(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600AF6F RID: 44911 RVA: 0x000F87AC File Offset: 0x000F69AC
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkActor2D.vtkActor2D_HasTranslucentPolygonalGeometry_16(base.GetCppThis());
		}

		// Token: 0x0600AF70 RID: 44912
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor2D_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AF71 RID: 44913 RVA: 0x000F87CC File Offset: 0x000F69CC
		public override int IsA(string type)
		{
			return vtkActor2D.vtkActor2D_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0600AF72 RID: 44914
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor2D_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AF73 RID: 44915 RVA: 0x000F87EC File Offset: 0x000F69EC
		public new static int IsTypeOf(string type)
		{
			return vtkActor2D.vtkActor2D_IsTypeOf_18(type);
		}

		// Token: 0x0600AF74 RID: 44916
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2D_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AF75 RID: 44917 RVA: 0x000F8808 File Offset: 0x000F6A08
		public new vtkActor2D NewInstance()
		{
			vtkActor2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2D.vtkActor2D_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600AF76 RID: 44918
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2D_ReleaseGraphicsResources_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600AF77 RID: 44919 RVA: 0x000F8864 File Offset: 0x000F6A64
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkActor2D.vtkActor2D_ReleaseGraphicsResources_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AF78 RID: 44920
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor2D_RenderOpaqueGeometry_22(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x0600AF79 RID: 44921 RVA: 0x000F8894 File Offset: 0x000F6A94
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkActor2D.vtkActor2D_RenderOpaqueGeometry_22(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600AF7A RID: 44922
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor2D_RenderOverlay_23(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x0600AF7B RID: 44923 RVA: 0x000F88C8 File Offset: 0x000F6AC8
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkActor2D.vtkActor2D_RenderOverlay_23(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600AF7C RID: 44924
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor2D_RenderTranslucentPolygonalGeometry_24(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x0600AF7D RID: 44925 RVA: 0x000F88FC File Offset: 0x000F6AFC
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkActor2D.vtkActor2D_RenderTranslucentPolygonalGeometry_24(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600AF7E RID: 44926
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2D_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AF7F RID: 44927 RVA: 0x000F8930 File Offset: 0x000F6B30
		public new static vtkActor2D SafeDownCast(vtkObjectBase o)
		{
			vtkActor2D vtkActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2D.vtkActor2D_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor2D = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor2D.Register(null);
				}
			}
			return vtkActor2D;
		}

		// Token: 0x0600AF80 RID: 44928
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2D_SetDisplayPosition_26(HandleRef pThis, int arg0, int arg1);

		/// <summary>
		/// Set the Prop2D's position in display coordinates.
		/// </summary>
		// Token: 0x0600AF81 RID: 44929 RVA: 0x000F89AF File Offset: 0x000F6BAF
		public void SetDisplayPosition(int arg0, int arg1)
		{
			vtkActor2D.vtkActor2D_SetDisplayPosition_26(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0600AF82 RID: 44930
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2D_SetHeight_27(HandleRef pThis, double h);

		/// <summary>
		/// Set/Get the height and width of the Actor2D. The value is expressed
		/// as a fraction of the viewport. This really is just another way of
		/// setting the Position2 instance variable.
		/// </summary>
		// Token: 0x0600AF83 RID: 44931 RVA: 0x000F89C0 File Offset: 0x000F6BC0
		public void SetHeight(double h)
		{
			vtkActor2D.vtkActor2D_SetHeight_27(base.GetCppThis(), h);
		}

		// Token: 0x0600AF84 RID: 44932
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2D_SetLayerNumber_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the layer number in the overlay planes into which to render.
		/// </summary>
		// Token: 0x0600AF85 RID: 44933 RVA: 0x000F89D0 File Offset: 0x000F6BD0
		public virtual void SetLayerNumber(int _arg)
		{
			vtkActor2D.vtkActor2D_SetLayerNumber_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AF86 RID: 44934
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2D_SetMapper_29(HandleRef pThis, HandleRef mapper);

		/// <summary>
		/// Set/Get the vtkMapper2D which defines the data to be drawn.
		/// </summary>
		// Token: 0x0600AF87 RID: 44935 RVA: 0x000F89E0 File Offset: 0x000F6BE0
		public virtual void SetMapper(vtkMapper2D mapper)
		{
			vtkActor2D.vtkActor2D_SetMapper_29(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x0600AF88 RID: 44936
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2D_SetPosition_30(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Get the PositionCoordinate instance of vtkCoordinate.
		/// This is used for for complicated or relative positioning.
		/// The position variable controls the lower left corner of the Actor2D
		/// </summary>
		// Token: 0x0600AF89 RID: 44937 RVA: 0x000F8A0F File Offset: 0x000F6C0F
		public virtual void SetPosition(IntPtr x)
		{
			vtkActor2D.vtkActor2D_SetPosition_30(base.GetCppThis(), x);
		}

		// Token: 0x0600AF8A RID: 44938
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2D_SetPosition_31(HandleRef pThis, double x, double y);

		/// <summary>
		/// Get the PositionCoordinate instance of vtkCoordinate.
		/// This is used for for complicated or relative positioning.
		/// The position variable controls the lower left corner of the Actor2D
		/// </summary>
		// Token: 0x0600AF8B RID: 44939 RVA: 0x000F8A1F File Offset: 0x000F6C1F
		public virtual void SetPosition(double x, double y)
		{
			vtkActor2D.vtkActor2D_SetPosition_31(base.GetCppThis(), x, y);
		}

		// Token: 0x0600AF8C RID: 44940
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2D_SetPosition2_32(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Access the Position2 instance variable. This variable controls
		/// the upper right corner of the Actor2D. It is by default
		/// relative to Position and in normalized viewport coordinates.
		/// Some 2D actor subclasses ignore the position2 variable
		/// </summary>
		// Token: 0x0600AF8D RID: 44941 RVA: 0x000F8A30 File Offset: 0x000F6C30
		public virtual void SetPosition2(IntPtr x)
		{
			vtkActor2D.vtkActor2D_SetPosition2_32(base.GetCppThis(), x);
		}

		// Token: 0x0600AF8E RID: 44942
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2D_SetPosition2_33(HandleRef pThis, double x, double y);

		/// <summary>
		/// Access the Position2 instance variable. This variable controls
		/// the upper right corner of the Actor2D. It is by default
		/// relative to Position and in normalized viewport coordinates.
		/// Some 2D actor subclasses ignore the position2 variable
		/// </summary>
		// Token: 0x0600AF8F RID: 44943 RVA: 0x000F8A40 File Offset: 0x000F6C40
		public virtual void SetPosition2(double x, double y)
		{
			vtkActor2D.vtkActor2D_SetPosition2_33(base.GetCppThis(), x, y);
		}

		// Token: 0x0600AF90 RID: 44944
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2D_SetProperty_34(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set this vtkProp's vtkProperty2D.
		/// </summary>
		// Token: 0x0600AF91 RID: 44945 RVA: 0x000F8A54 File Offset: 0x000F6C54
		public virtual void SetProperty(vtkProperty2D arg0)
		{
			vtkActor2D.vtkActor2D_SetProperty_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AF92 RID: 44946
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2D_SetWidth_35(HandleRef pThis, double w);

		/// <summary>
		/// Set/Get the height and width of the Actor2D. The value is expressed
		/// as a fraction of the viewport. This really is just another way of
		/// setting the Position2 instance variable.
		/// </summary>
		// Token: 0x0600AF93 RID: 44947 RVA: 0x000F8A83 File Offset: 0x000F6C83
		public void SetWidth(double w)
		{
			vtkActor2D.vtkActor2D_SetWidth_35(base.GetCppThis(), w);
		}

		// Token: 0x0600AF94 RID: 44948
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2D_ShallowCopy_36(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of this vtkActor2D. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x0600AF95 RID: 44949 RVA: 0x000F8A94 File Offset: 0x000F6C94
		public override void ShallowCopy(vtkProp prop)
		{
			vtkActor2D.vtkActor2D_ShallowCopy_36(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DB7 RID: 3511
		public new const string MRFullTypeName = "Kitware.VTK.vtkActor2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DB8 RID: 3512
		public new static readonly string MRClassNameKey = "class vtkActor2D";
	}
}
