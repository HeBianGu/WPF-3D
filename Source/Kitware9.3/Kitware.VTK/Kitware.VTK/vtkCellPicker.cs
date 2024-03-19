using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellPicker
	/// </summary>
	/// <remarks>
	///    ray-cast cell picker for all kinds of Prop3Ds
	///
	/// vtkCellPicker will shoot a ray into a 3D scene and return information
	/// about the first object that the ray hits.  It works for all Prop3Ds.
	/// For vtkVolume objects, it shoots a ray into the volume and returns
	/// the point where the ray intersects an isosurface of a chosen opacity.
	/// For vtkImage objects, it intersects the ray with the displayed
	/// slice. For vtkActor objects, it intersects the actor's polygons.
	/// If the object's mapper has ClippingPlanes, then it takes the clipping
	/// into account, and will return the Id of the clipping plane that was
	/// intersected.
	/// For all prop types, it returns point and cell information, plus the
	/// normal of the surface that was intersected at the pick position.  For
	/// volumes and images, it also returns (i,j,k) coordinates for the point
	/// and the cell that were picked.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPicker vtkPointPicker vtkVolumePicker
	///
	/// @par Thanks:
	/// This class was contributed to VTK by David Gobbi on behalf of Atamai Inc.,
	/// as an enhancement to the original vtkCellPicker.
	/// </seealso>
	// Token: 0x020003AD RID: 941
	public class vtkCellPicker : vtkPicker
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600AB3C RID: 43836 RVA: 0x000F33EB File Offset: 0x000F15EB
		static vtkCellPicker()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellPicker"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600AB3D RID: 43837 RVA: 0x000F3413 File Offset: 0x000F1613
		public vtkCellPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600AB3E RID: 43838
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB3F RID: 43839 RVA: 0x000F3424 File Offset: 0x000F1624
		public new static vtkCellPicker New()
		{
			vtkCellPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB40 RID: 43840 RVA: 0x000F3478 File Offset: 0x000F1678
		public vtkCellPicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellPicker.vtkCellPicker_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600AB41 RID: 43841 RVA: 0x000F34BC File Offset: 0x000F16BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600AB42 RID: 43842
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_AddLocator_01(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Add a locator for one of the data sets that will be included in the
		/// scene.  You must set up the locator with exactly the same data set
		/// that was input to the mapper of one or more of the actors in the
		/// scene. Note that if you try to add the
		/// same locator to the picker twice, the second addition will be ignored.
		/// </summary>
		// Token: 0x0600AB43 RID: 43843 RVA: 0x000F34C8 File Offset: 0x000F16C8
		public void AddLocator(vtkAbstractCellLocator locator)
		{
			vtkCellPicker.vtkCellPicker_AddLocator_01(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600AB44 RID: 43844
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellPicker_GetCellIJK_02(HandleRef pThis);

		/// <summary>
		/// Get the structured coordinates of the cell at the PickPosition.
		/// Only valid for image actors and volumes with vtkImageData.
		/// Combine this with the PCoords to get the position within the cell.
		/// </summary>
		// Token: 0x0600AB45 RID: 43845 RVA: 0x000F34F8 File Offset: 0x000F16F8
		public virtual int[] GetCellIJK()
		{
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_GetCellIJK_02(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AB46 RID: 43846
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_GetCellIJK_03(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Get the structured coordinates of the cell at the PickPosition.
		/// Only valid for image actors and volumes with vtkImageData.
		/// Combine this with the PCoords to get the position within the cell.
		/// </summary>
		// Token: 0x0600AB47 RID: 43847 RVA: 0x000F3540 File Offset: 0x000F1740
		public virtual void GetCellIJK(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkCellPicker.vtkCellPicker_GetCellIJK_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600AB48 RID: 43848
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_GetCellIJK_04(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the structured coordinates of the cell at the PickPosition.
		/// Only valid for image actors and volumes with vtkImageData.
		/// Combine this with the PCoords to get the position within the cell.
		/// </summary>
		// Token: 0x0600AB49 RID: 43849 RVA: 0x000F3552 File Offset: 0x000F1752
		public virtual void GetCellIJK(IntPtr _arg)
		{
			vtkCellPicker.vtkCellPicker_GetCellIJK_04(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB4A RID: 43850
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellPicker_GetCellId_05(HandleRef pThis);

		/// <summary>
		/// Get the id of the picked cell. If CellId = -1, nothing was picked.
		/// </summary>
		// Token: 0x0600AB4B RID: 43851 RVA: 0x000F3564 File Offset: 0x000F1764
		public virtual long GetCellId()
		{
			return vtkCellPicker.vtkCellPicker_GetCellId_05(base.GetCppThis());
		}

		// Token: 0x0600AB4C RID: 43852
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellPicker_GetClippingPlaneId_06(HandleRef pThis);

		/// <summary>
		/// Get the index of the clipping plane that was intersected during
		/// the pick.  This will be set regardless of whether PickClippingPlanes
		/// is On, all that is required is that the pick intersected a clipping
		/// plane of the Prop3D that was picked.  The result will be -1 if the
		/// Prop3D that was picked has no clipping planes, or if the ray didn't
		/// intersect the planes.
		/// </summary>
		// Token: 0x0600AB4D RID: 43853 RVA: 0x000F3584 File Offset: 0x000F1784
		public virtual int GetClippingPlaneId()
		{
			return vtkCellPicker.vtkCellPicker_GetClippingPlaneId_06(base.GetCppThis());
		}

		// Token: 0x0600AB4E RID: 43854
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellPicker_GetMapperNormal_07(HandleRef pThis);

		/// <summary>
		/// Return the normal of the surface at the PickPosition in mapper
		/// coordinates.  The result is undefined if no prop was picked.
		/// </summary>
		// Token: 0x0600AB4F RID: 43855 RVA: 0x000F35A4 File Offset: 0x000F17A4
		public virtual double[] GetMapperNormal()
		{
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_GetMapperNormal_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AB50 RID: 43856
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_GetMapperNormal_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Return the normal of the surface at the PickPosition in mapper
		/// coordinates.  The result is undefined if no prop was picked.
		/// </summary>
		// Token: 0x0600AB51 RID: 43857 RVA: 0x000F35EC File Offset: 0x000F17EC
		public virtual void GetMapperNormal(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCellPicker.vtkCellPicker_GetMapperNormal_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600AB52 RID: 43858
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_GetMapperNormal_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Return the normal of the surface at the PickPosition in mapper
		/// coordinates.  The result is undefined if no prop was picked.
		/// </summary>
		// Token: 0x0600AB53 RID: 43859 RVA: 0x000F35FE File Offset: 0x000F17FE
		public virtual void GetMapperNormal(IntPtr _arg)
		{
			vtkCellPicker.vtkCellPicker_GetMapperNormal_09(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB54 RID: 43860
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellPicker_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB55 RID: 43861 RVA: 0x000F3610 File Offset: 0x000F1810
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellPicker.vtkCellPicker_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0600AB56 RID: 43862
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellPicker_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB57 RID: 43863 RVA: 0x000F3630 File Offset: 0x000F1830
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellPicker.vtkCellPicker_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0600AB58 RID: 43864
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellPicker_GetPCoords_12(HandleRef pThis);

		/// <summary>
		/// Get the parametric coordinates of the picked cell. Only valid if
		/// a prop was picked.  The PCoords can be used to compute the weights
		/// that are needed to interpolate data values within the cell.
		/// </summary>
		// Token: 0x0600AB59 RID: 43865 RVA: 0x000F364C File Offset: 0x000F184C
		public virtual double[] GetPCoords()
		{
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_GetPCoords_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AB5A RID: 43866
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_GetPCoords_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the parametric coordinates of the picked cell. Only valid if
		/// a prop was picked.  The PCoords can be used to compute the weights
		/// that are needed to interpolate data values within the cell.
		/// </summary>
		// Token: 0x0600AB5B RID: 43867 RVA: 0x000F3694 File Offset: 0x000F1894
		public virtual void GetPCoords(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCellPicker.vtkCellPicker_GetPCoords_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600AB5C RID: 43868
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_GetPCoords_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the parametric coordinates of the picked cell. Only valid if
		/// a prop was picked.  The PCoords can be used to compute the weights
		/// that are needed to interpolate data values within the cell.
		/// </summary>
		// Token: 0x0600AB5D RID: 43869 RVA: 0x000F36A6 File Offset: 0x000F18A6
		public virtual void GetPCoords(IntPtr _arg)
		{
			vtkCellPicker.vtkCellPicker_GetPCoords_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB5E RID: 43870
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellPicker_GetPickClippingPlanes_15(HandleRef pThis);

		/// <summary>
		/// The PickClippingPlanes setting controls how clipping planes are
		/// handled by the pick.  If it is On, then the clipping planes become
		/// pickable objects, even though they are usually invisible.  This
		/// means that if the pick ray intersects a clipping plane before it
		/// hits anything else, the pick will stop at that clipping plane.
		/// The GetProp3D() and GetMapper() methods will return the Prop3D
		/// and Mapper that the clipping plane belongs to.  The
		/// GetClippingPlaneId() method will return the index of the clipping
		/// plane so that you can retrieve it from the mapper, or -1 if no
		/// clipping plane was picked.
		/// </summary>
		// Token: 0x0600AB5F RID: 43871 RVA: 0x000F36B8 File Offset: 0x000F18B8
		public virtual int GetPickClippingPlanes()
		{
			return vtkCellPicker.vtkCellPicker_GetPickClippingPlanes_15(base.GetCppThis());
		}

		// Token: 0x0600AB60 RID: 43872
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellPicker_GetPickNormal_16(HandleRef pThis);

		/// <summary>
		/// Return the normal of the picked surface at the PickPosition.  If no
		/// surface was picked, then a vector pointing back at the camera is
		/// returned.
		/// </summary>
		// Token: 0x0600AB61 RID: 43873 RVA: 0x000F36D8 File Offset: 0x000F18D8
		public virtual double[] GetPickNormal()
		{
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_GetPickNormal_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AB62 RID: 43874
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_GetPickNormal_17(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Return the normal of the picked surface at the PickPosition.  If no
		/// surface was picked, then a vector pointing back at the camera is
		/// returned.
		/// </summary>
		// Token: 0x0600AB63 RID: 43875 RVA: 0x000F3720 File Offset: 0x000F1920
		public virtual void GetPickNormal(IntPtr data)
		{
			vtkCellPicker.vtkCellPicker_GetPickNormal_17(base.GetCppThis(), data);
		}

		// Token: 0x0600AB64 RID: 43876
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellPicker_GetPickTextureData_18(HandleRef pThis);

		/// <summary>
		/// If this is "On" and if the picked prop has a texture, then the data
		/// returned by GetDataSet() will be the texture's data instead of the
		/// mapper's data.  The GetPointId(), GetCellId(), GetPCoords() etc. will
		/// all return information for use with the texture's data.  If the picked
		/// prop does not have any texture, then GetDataSet() will return the
		/// mapper's data instead and GetPointId() etc. will return information
		/// related to the mapper's data.  The default value of PickTextureData
		/// is "Off".
		/// </summary>
		// Token: 0x0600AB65 RID: 43877 RVA: 0x000F3730 File Offset: 0x000F1930
		public virtual int GetPickTextureData()
		{
			return vtkCellPicker.vtkCellPicker_GetPickTextureData_18(base.GetCppThis());
		}

		// Token: 0x0600AB66 RID: 43878
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellPicker_GetPointIJK_19(HandleRef pThis);

		/// <summary>
		/// Get the structured coordinates of the point at the PickPosition.
		/// Only valid for image actors and volumes with vtkImageData.
		/// </summary>
		// Token: 0x0600AB67 RID: 43879 RVA: 0x000F3750 File Offset: 0x000F1950
		public virtual int[] GetPointIJK()
		{
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_GetPointIJK_19(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AB68 RID: 43880
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_GetPointIJK_20(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Get the structured coordinates of the point at the PickPosition.
		/// Only valid for image actors and volumes with vtkImageData.
		/// </summary>
		// Token: 0x0600AB69 RID: 43881 RVA: 0x000F3798 File Offset: 0x000F1998
		public virtual void GetPointIJK(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkCellPicker.vtkCellPicker_GetPointIJK_20(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600AB6A RID: 43882
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_GetPointIJK_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the structured coordinates of the point at the PickPosition.
		/// Only valid for image actors and volumes with vtkImageData.
		/// </summary>
		// Token: 0x0600AB6B RID: 43883 RVA: 0x000F37AA File Offset: 0x000F19AA
		public virtual void GetPointIJK(IntPtr _arg)
		{
			vtkCellPicker.vtkCellPicker_GetPointIJK_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB6C RID: 43884
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellPicker_GetPointId_22(HandleRef pThis);

		/// <summary>
		/// Get the id of the picked point. If PointId = -1, nothing was picked.
		/// This point will be a member of any cell that is picked.
		/// </summary>
		// Token: 0x0600AB6D RID: 43885 RVA: 0x000F37BC File Offset: 0x000F19BC
		public virtual long GetPointId()
		{
			return vtkCellPicker.vtkCellPicker_GetPointId_22(base.GetCppThis());
		}

		// Token: 0x0600AB6E RID: 43886
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellPicker_GetSubId_23(HandleRef pThis);

		/// <summary>
		/// Get the subId of the picked cell. This is useful, for example, if
		/// the data is made of triangle strips. If SubId = -1, nothing was picked.
		/// </summary>
		// Token: 0x0600AB6F RID: 43887 RVA: 0x000F37DC File Offset: 0x000F19DC
		public virtual int GetSubId()
		{
			return vtkCellPicker.vtkCellPicker_GetSubId_23(base.GetCppThis());
		}

		// Token: 0x0600AB70 RID: 43888
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellPicker_GetTexture_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the texture that was picked.  This will always be set if the
		/// picked prop has a texture, and will always be null otherwise.
		/// </summary>
		// Token: 0x0600AB71 RID: 43889 RVA: 0x000F37FC File Offset: 0x000F19FC
		public vtkTexture GetTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_GetTexture_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		// Token: 0x0600AB72 RID: 43890
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellPicker_GetUseVolumeGradientOpacity_25(HandleRef pThis);

		/// <summary>
		/// Use the product of the scalar and gradient opacity functions when
		/// computing the opacity isovalue, instead of just using the scalar
		/// opacity. This parameter is only relevant to volume picking and
		/// is off by default.
		/// </summary>
		// Token: 0x0600AB73 RID: 43891 RVA: 0x000F386C File Offset: 0x000F1A6C
		public virtual int GetUseVolumeGradientOpacity()
		{
			return vtkCellPicker.vtkCellPicker_GetUseVolumeGradientOpacity_25(base.GetCppThis());
		}

		// Token: 0x0600AB74 RID: 43892
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCellPicker_GetVolumeOpacityIsovalue_26(HandleRef pThis);

		/// <summary>
		/// Set the opacity isovalue to use for defining volume surfaces.  The
		/// pick will occur at the location along the pick ray where the
		/// opacity of the volume is equal to this isovalue.  If you want to do
		/// the pick based on an actual data isovalue rather than the opacity,
		/// then pass the data value through the scalar opacity function before
		/// using this method.
		/// </summary>
		// Token: 0x0600AB75 RID: 43893 RVA: 0x000F388C File Offset: 0x000F1A8C
		public virtual double GetVolumeOpacityIsovalue()
		{
			return vtkCellPicker.vtkCellPicker_GetVolumeOpacityIsovalue_26(base.GetCppThis());
		}

		// Token: 0x0600AB76 RID: 43894
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellPicker_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB77 RID: 43895 RVA: 0x000F38AC File Offset: 0x000F1AAC
		public override int IsA(string type)
		{
			return vtkCellPicker.vtkCellPicker_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x0600AB78 RID: 43896
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellPicker_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB79 RID: 43897 RVA: 0x000F38CC File Offset: 0x000F1ACC
		public new static int IsTypeOf(string type)
		{
			return vtkCellPicker.vtkCellPicker_IsTypeOf_28(type);
		}

		// Token: 0x0600AB7A RID: 43898
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellPicker_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB7B RID: 43899 RVA: 0x000F38E8 File Offset: 0x000F1AE8
		public new vtkCellPicker NewInstance()
		{
			vtkCellPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600AB7C RID: 43900
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellPicker_Pick_31(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

		/// <summary>
		/// Perform pick operation with selection point provided. Normally the
		/// first two values are the (x,y) pixel coordinates for the pick, and
		/// the third value is z=0. The return value will be non-zero if
		/// something was successfully picked.
		/// </summary>
		// Token: 0x0600AB7D RID: 43901 RVA: 0x000F3944 File Offset: 0x000F1B44
		public override int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
		{
			return vtkCellPicker.vtkCellPicker_Pick_31(base.GetCppThis(), selectionX, selectionY, selectionZ, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x0600AB7E RID: 43902
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellPicker_Pick3DRay_32(HandleRef pThis, IntPtr selectionPt, IntPtr orient, HandleRef ren);

		/// <summary>
		/// Perform pick operation with selection point provided. The
		/// selectionPt is in world coordinates.
		/// Return non-zero if something was successfully picked.
		/// </summary>
		// Token: 0x0600AB7F RID: 43903 RVA: 0x000F3980 File Offset: 0x000F1B80
		public override int Pick3DRay(IntPtr selectionPt, IntPtr orient, vtkRenderer ren)
		{
			return vtkCellPicker.vtkCellPicker_Pick3DRay_32(base.GetCppThis(), selectionPt, orient, (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x0600AB80 RID: 43904
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_PickClippingPlanesOff_33(HandleRef pThis);

		/// <summary>
		/// The PickClippingPlanes setting controls how clipping planes are
		/// handled by the pick.  If it is On, then the clipping planes become
		/// pickable objects, even though they are usually invisible.  This
		/// means that if the pick ray intersects a clipping plane before it
		/// hits anything else, the pick will stop at that clipping plane.
		/// The GetProp3D() and GetMapper() methods will return the Prop3D
		/// and Mapper that the clipping plane belongs to.  The
		/// GetClippingPlaneId() method will return the index of the clipping
		/// plane so that you can retrieve it from the mapper, or -1 if no
		/// clipping plane was picked.
		/// </summary>
		// Token: 0x0600AB81 RID: 43905 RVA: 0x000F39B6 File Offset: 0x000F1BB6
		public virtual void PickClippingPlanesOff()
		{
			vtkCellPicker.vtkCellPicker_PickClippingPlanesOff_33(base.GetCppThis());
		}

		// Token: 0x0600AB82 RID: 43906
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_PickClippingPlanesOn_34(HandleRef pThis);

		/// <summary>
		/// The PickClippingPlanes setting controls how clipping planes are
		/// handled by the pick.  If it is On, then the clipping planes become
		/// pickable objects, even though they are usually invisible.  This
		/// means that if the pick ray intersects a clipping plane before it
		/// hits anything else, the pick will stop at that clipping plane.
		/// The GetProp3D() and GetMapper() methods will return the Prop3D
		/// and Mapper that the clipping plane belongs to.  The
		/// GetClippingPlaneId() method will return the index of the clipping
		/// plane so that you can retrieve it from the mapper, or -1 if no
		/// clipping plane was picked.
		/// </summary>
		// Token: 0x0600AB83 RID: 43907 RVA: 0x000F39C5 File Offset: 0x000F1BC5
		public virtual void PickClippingPlanesOn()
		{
			vtkCellPicker.vtkCellPicker_PickClippingPlanesOn_34(base.GetCppThis());
		}

		// Token: 0x0600AB84 RID: 43908
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_PickTextureDataOff_35(HandleRef pThis);

		/// <summary>
		/// If this is "On" and if the picked prop has a texture, then the data
		/// returned by GetDataSet() will be the texture's data instead of the
		/// mapper's data.  The GetPointId(), GetCellId(), GetPCoords() etc. will
		/// all return information for use with the texture's data.  If the picked
		/// prop does not have any texture, then GetDataSet() will return the
		/// mapper's data instead and GetPointId() etc. will return information
		/// related to the mapper's data.  The default value of PickTextureData
		/// is "Off".
		/// </summary>
		// Token: 0x0600AB85 RID: 43909 RVA: 0x000F39D4 File Offset: 0x000F1BD4
		public virtual void PickTextureDataOff()
		{
			vtkCellPicker.vtkCellPicker_PickTextureDataOff_35(base.GetCppThis());
		}

		// Token: 0x0600AB86 RID: 43910
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_PickTextureDataOn_36(HandleRef pThis);

		/// <summary>
		/// If this is "On" and if the picked prop has a texture, then the data
		/// returned by GetDataSet() will be the texture's data instead of the
		/// mapper's data.  The GetPointId(), GetCellId(), GetPCoords() etc. will
		/// all return information for use with the texture's data.  If the picked
		/// prop does not have any texture, then GetDataSet() will return the
		/// mapper's data instead and GetPointId() etc. will return information
		/// related to the mapper's data.  The default value of PickTextureData
		/// is "Off".
		/// </summary>
		// Token: 0x0600AB87 RID: 43911 RVA: 0x000F39E3 File Offset: 0x000F1BE3
		public virtual void PickTextureDataOn()
		{
			vtkCellPicker.vtkCellPicker_PickTextureDataOn_36(base.GetCppThis());
		}

		// Token: 0x0600AB88 RID: 43912
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_RemoveAllLocators_37(HandleRef pThis);

		/// <summary>
		/// Remove all locators associated with this picker.
		/// </summary>
		// Token: 0x0600AB89 RID: 43913 RVA: 0x000F39F2 File Offset: 0x000F1BF2
		public void RemoveAllLocators()
		{
			vtkCellPicker.vtkCellPicker_RemoveAllLocators_37(base.GetCppThis());
		}

		// Token: 0x0600AB8A RID: 43914
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_RemoveLocator_38(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Remove a locator that was previously added.  If you try to remove a
		/// nonexistent locator, then nothing will happen and no errors will be
		/// raised.
		/// </summary>
		// Token: 0x0600AB8B RID: 43915 RVA: 0x000F3A04 File Offset: 0x000F1C04
		public void RemoveLocator(vtkAbstractCellLocator locator)
		{
			vtkCellPicker.vtkCellPicker_RemoveLocator_38(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600AB8C RID: 43916
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellPicker_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB8D RID: 43917 RVA: 0x000F3A34 File Offset: 0x000F1C34
		public new static vtkCellPicker SafeDownCast(vtkObjectBase o)
		{
			vtkCellPicker vtkCellPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellPicker = (vtkCellPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellPicker.Register(null);
				}
			}
			return vtkCellPicker;
		}

		// Token: 0x0600AB8E RID: 43918
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_SetPickClippingPlanes_40(HandleRef pThis, int _arg);

		/// <summary>
		/// The PickClippingPlanes setting controls how clipping planes are
		/// handled by the pick.  If it is On, then the clipping planes become
		/// pickable objects, even though they are usually invisible.  This
		/// means that if the pick ray intersects a clipping plane before it
		/// hits anything else, the pick will stop at that clipping plane.
		/// The GetProp3D() and GetMapper() methods will return the Prop3D
		/// and Mapper that the clipping plane belongs to.  The
		/// GetClippingPlaneId() method will return the index of the clipping
		/// plane so that you can retrieve it from the mapper, or -1 if no
		/// clipping plane was picked.
		/// </summary>
		// Token: 0x0600AB8F RID: 43919 RVA: 0x000F3AB3 File Offset: 0x000F1CB3
		public virtual void SetPickClippingPlanes(int _arg)
		{
			vtkCellPicker.vtkCellPicker_SetPickClippingPlanes_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB90 RID: 43920
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_SetPickTextureData_41(HandleRef pThis, int _arg);

		/// <summary>
		/// If this is "On" and if the picked prop has a texture, then the data
		/// returned by GetDataSet() will be the texture's data instead of the
		/// mapper's data.  The GetPointId(), GetCellId(), GetPCoords() etc. will
		/// all return information for use with the texture's data.  If the picked
		/// prop does not have any texture, then GetDataSet() will return the
		/// mapper's data instead and GetPointId() etc. will return information
		/// related to the mapper's data.  The default value of PickTextureData
		/// is "Off".
		/// </summary>
		// Token: 0x0600AB91 RID: 43921 RVA: 0x000F3AC3 File Offset: 0x000F1CC3
		public virtual void SetPickTextureData(int _arg)
		{
			vtkCellPicker.vtkCellPicker_SetPickTextureData_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB92 RID: 43922
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_SetUseVolumeGradientOpacity_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Use the product of the scalar and gradient opacity functions when
		/// computing the opacity isovalue, instead of just using the scalar
		/// opacity. This parameter is only relevant to volume picking and
		/// is off by default.
		/// </summary>
		// Token: 0x0600AB93 RID: 43923 RVA: 0x000F3AD3 File Offset: 0x000F1CD3
		public virtual void SetUseVolumeGradientOpacity(int _arg)
		{
			vtkCellPicker.vtkCellPicker_SetUseVolumeGradientOpacity_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB94 RID: 43924
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_SetVolumeOpacityIsovalue_43(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the opacity isovalue to use for defining volume surfaces.  The
		/// pick will occur at the location along the pick ray where the
		/// opacity of the volume is equal to this isovalue.  If you want to do
		/// the pick based on an actual data isovalue rather than the opacity,
		/// then pass the data value through the scalar opacity function before
		/// using this method.
		/// </summary>
		// Token: 0x0600AB95 RID: 43925 RVA: 0x000F3AE3 File Offset: 0x000F1CE3
		public virtual void SetVolumeOpacityIsovalue(double _arg)
		{
			vtkCellPicker.vtkCellPicker_SetVolumeOpacityIsovalue_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB96 RID: 43926
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_UseVolumeGradientOpacityOff_44(HandleRef pThis);

		/// <summary>
		/// Use the product of the scalar and gradient opacity functions when
		/// computing the opacity isovalue, instead of just using the scalar
		/// opacity. This parameter is only relevant to volume picking and
		/// is off by default.
		/// </summary>
		// Token: 0x0600AB97 RID: 43927 RVA: 0x000F3AF3 File Offset: 0x000F1CF3
		public virtual void UseVolumeGradientOpacityOff()
		{
			vtkCellPicker.vtkCellPicker_UseVolumeGradientOpacityOff_44(base.GetCppThis());
		}

		// Token: 0x0600AB98 RID: 43928
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellPicker_UseVolumeGradientOpacityOn_45(HandleRef pThis);

		/// <summary>
		/// Use the product of the scalar and gradient opacity functions when
		/// computing the opacity isovalue, instead of just using the scalar
		/// opacity. This parameter is only relevant to volume picking and
		/// is off by default.
		/// </summary>
		// Token: 0x0600AB99 RID: 43929 RVA: 0x000F3B02 File Offset: 0x000F1D02
		public virtual void UseVolumeGradientOpacityOn()
		{
			vtkCellPicker.vtkCellPicker_UseVolumeGradientOpacityOn_45(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D8F RID: 3471
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellPicker";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D90 RID: 3472
		public new static readonly string MRClassNameKey = "class vtkCellPicker";
	}
}
