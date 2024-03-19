using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkMultiVolume
	/// </summary>
	/// <remarks>
	///  Represents a world axis-aligned bounding-box containing a set of
	/// volumes in a rendered scene.
	///
	/// vtkVolume instances registered in this class can be overlapping. They are
	/// intended to be all rendered simultaneously by a vtkGPUVolumeRayCastMapper
	/// (inputs should be set directly in the mapper).
	///
	/// This class holds the full transformation of a bounding-box containing
	/// all of the registered volumes.
	///
	///      + TexToBBox : Texture-to-Data (scaling)
	///      + Matrix : Data-to-World (translation)
	///
	/// @note This class is intended to be used only by mappers supporting multiple
	/// inputs.
	///
	/// </remarks>
	/// <seealso>
	///  vtkVolume vtkAbstractVolumeMapper vtkGPUVolumeRayCastMapper
	/// </seealso>
	// Token: 0x0200039E RID: 926
	public class vtkMultiVolume : vtkVolume
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A8C7 RID: 43207 RVA: 0x000EF88B File Offset: 0x000EDA8B
		static vtkMultiVolume()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiVolume.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiVolume"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A8C8 RID: 43208 RVA: 0x000EF8B3 File Offset: 0x000EDAB3
		public vtkMultiVolume(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A8C9 RID: 43209
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiVolume_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8CA RID: 43210 RVA: 0x000EF8C4 File Offset: 0x000EDAC4
		public new static vtkMultiVolume New()
		{
			vtkMultiVolume result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiVolume.vtkMultiVolume_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8CB RID: 43211 RVA: 0x000EF918 File Offset: 0x000EDB18
		public vtkMultiVolume() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMultiVolume.vtkMultiVolume_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A8CC RID: 43212 RVA: 0x000EF95C File Offset: 0x000EDB5C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A8CD RID: 43213
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiVolume_GetBounds_01(HandleRef pThis);

		/// <summary>
		/// Computes the bounds of the box containing all of the vtkVolume instances.
		/// Returns the bounds (vtkVolume::Bounds) in world coordinates [xmin, xmax,
		/// ymin, ymax, zmin, zmax] but also keeps cached the bounds in data coordinates
		/// (vtkMultiVolume::DataBounds).
		/// </summary>
		// Token: 0x0600A8CE RID: 43214 RVA: 0x000EF968 File Offset: 0x000EDB68
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkMultiVolume.vtkMultiVolume_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A8CF RID: 43215
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkMultiVolume_GetBoundsTime_02(HandleRef pThis);

		/// <summary>
		/// Total bounds in data coordinates.
		/// </summary>
		// Token: 0x0600A8D0 RID: 43216 RVA: 0x000EF9B0 File Offset: 0x000EDBB0
		public ulong GetBoundsTime()
		{
			return vtkMultiVolume.vtkMultiVolume_GetBoundsTime_02(base.GetCppThis());
		}

		// Token: 0x0600A8D1 RID: 43217
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiVolume_GetDataBounds_03(HandleRef pThis);

		/// <summary>
		/// Total bounds in data coordinates.
		/// </summary>
		// Token: 0x0600A8D2 RID: 43218 RVA: 0x000EF9D0 File Offset: 0x000EDBD0
		public IntPtr GetDataBounds()
		{
			return vtkMultiVolume.vtkMultiVolume_GetDataBounds_03(base.GetCppThis());
		}

		// Token: 0x0600A8D3 RID: 43219
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiVolume_GetDataGeometry_04(HandleRef pThis);

		/// <summary>
		/// Return the eight corners of the volume
		/// </summary>
		// Token: 0x0600A8D4 RID: 43220 RVA: 0x000EF9F0 File Offset: 0x000EDBF0
		public IntPtr GetDataGeometry()
		{
			return vtkMultiVolume.vtkMultiVolume_GetDataGeometry_04(base.GetCppThis());
		}

		// Token: 0x0600A8D5 RID: 43221
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkMultiVolume_GetMTime_05(HandleRef pThis);

		/// <summary>
		/// \sa vtkVolume
		/// </summary>
		// Token: 0x0600A8D6 RID: 43222 RVA: 0x000EFA10 File Offset: 0x000EDC10
		public override ulong GetMTime()
		{
			return vtkMultiVolume.vtkMultiVolume_GetMTime_05(base.GetCppThis());
		}

		// Token: 0x0600A8D7 RID: 43223
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiVolume_GetMatrix_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// As with other vtkProp3D, Matrix holds the transformation from data
		/// coordinates to world coordinates.  Since this class represents an
		/// axis-aligned bounding-box, this transformation only contains a translation
		/// vector. Each registered vtkVolume contains its own transformation with
		/// respect to the world coordinate system.
		/// \sa vtkProp3D vtkVolume
		/// </summary>
		// Token: 0x0600A8D8 RID: 43224 RVA: 0x000EFA30 File Offset: 0x000EDC30
		public override vtkMatrix4x4 GetMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiVolume.vtkMultiVolume_GetMatrix_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A8D9 RID: 43225
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiVolume_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8DA RID: 43226 RVA: 0x000EFAA0 File Offset: 0x000EDCA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiVolume.vtkMultiVolume_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600A8DB RID: 43227
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiVolume_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8DC RID: 43228 RVA: 0x000EFAC0 File Offset: 0x000EDCC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiVolume.vtkMultiVolume_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600A8DD RID: 43229
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiVolume_GetProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given that this class represents a bounding-box only there is no property
		/// directly associated with it (a cannot be set directly).
		/// This instance will return the property of the volume registered in the 0th
		/// port (or nullptr if no volume has been set).
		/// \sa vtkVolume
		/// </summary>
		// Token: 0x0600A8DE RID: 43230 RVA: 0x000EFADC File Offset: 0x000EDCDC
		public override vtkVolumeProperty GetProperty()
		{
			vtkVolumeProperty vtkVolumeProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiVolume.vtkMultiVolume_GetProperty_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeProperty = (vtkVolumeProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeProperty.Register(null);
				}
			}
			return vtkVolumeProperty;
		}

		// Token: 0x0600A8DF RID: 43231
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiVolume_GetTextureMatrix_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the transformation from texture coordinates to data cooridinates
		/// of the bounding-box. Since this class represents an axis-aligned bounding
		/// -boxThis, this transformation only contains a scaling diagonal.
		/// </summary>
		// Token: 0x0600A8E0 RID: 43232 RVA: 0x000EFB4C File Offset: 0x000EDD4C
		public vtkMatrix4x4 GetTextureMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiVolume.vtkMultiVolume_GetTextureMatrix_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A8E1 RID: 43233
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiVolume_GetVolume_11(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Add / Remove a vtkVolume instance.
		/// </summary>
		// Token: 0x0600A8E2 RID: 43234 RVA: 0x000EFBBC File Offset: 0x000EDDBC
		public vtkVolume GetVolume(int port)
		{
			vtkVolume vtkVolume = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiVolume.vtkMultiVolume_GetVolume_11(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolume = (vtkVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolume.Register(null);
				}
			}
			return vtkVolume;
		}

		// Token: 0x0600A8E3 RID: 43235
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiVolume_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8E4 RID: 43236 RVA: 0x000EFC2C File Offset: 0x000EDE2C
		public override int IsA(string type)
		{
			return vtkMultiVolume.vtkMultiVolume_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0600A8E5 RID: 43237
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiVolume_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8E6 RID: 43238 RVA: 0x000EFC4C File Offset: 0x000EDE4C
		public new static int IsTypeOf(string type)
		{
			return vtkMultiVolume.vtkMultiVolume_IsTypeOf_13(type);
		}

		// Token: 0x0600A8E7 RID: 43239
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiVolume_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8E8 RID: 43240 RVA: 0x000EFC68 File Offset: 0x000EDE68
		public new vtkMultiVolume NewInstance()
		{
			vtkMultiVolume result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiVolume.vtkMultiVolume_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A8E9 RID: 43241
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiVolume_RemoveVolume_16(HandleRef pThis, int port);

		/// <summary>
		/// Add / Remove a vtkVolume instance.
		/// </summary>
		// Token: 0x0600A8EA RID: 43242 RVA: 0x000EFCC2 File Offset: 0x000EDEC2
		public void RemoveVolume(int port)
		{
			vtkMultiVolume.vtkMultiVolume_RemoveVolume_16(base.GetCppThis(), port);
		}

		// Token: 0x0600A8EB RID: 43243
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiVolume_RenderVolumetricGeometry_17(HandleRef pThis, HandleRef vp);

		/// <summary>
		/// Since vtkMultiVolume acts like a proxy volume to compute the bounding box
		/// for its internal vtkVolume instances, there are no properties to be set directly
		/// in this instance. For that reason, this override ignores the vtkVolumeProperty
		/// check.
		/// </summary>
		// Token: 0x0600A8EC RID: 43244 RVA: 0x000EFCD4 File Offset: 0x000EDED4
		public override int RenderVolumetricGeometry(vtkViewport vp)
		{
			return vtkMultiVolume.vtkMultiVolume_RenderVolumetricGeometry_17(base.GetCppThis(), (vp == null) ? default(HandleRef) : vp.GetCppThis());
		}

		// Token: 0x0600A8ED RID: 43245
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiVolume_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A8EE RID: 43246 RVA: 0x000EFD08 File Offset: 0x000EDF08
		public new static vtkMultiVolume SafeDownCast(vtkObjectBase o)
		{
			vtkMultiVolume vtkMultiVolume = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiVolume.vtkMultiVolume_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiVolume = (vtkMultiVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiVolume.Register(null);
				}
			}
			return vtkMultiVolume;
		}

		// Token: 0x0600A8EF RID: 43247
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiVolume_SetProperty_19(HandleRef pThis, HandleRef property);

		/// <summary>
		/// Given that this class represents a bounding-box only there is no property
		/// directly associated with it (a cannot be set directly).
		/// This instance will return the property of the volume registered in the 0th
		/// port (or nullptr if no volume has been set).
		/// \sa vtkVolume
		/// </summary>
		// Token: 0x0600A8F0 RID: 43248 RVA: 0x000EFD88 File Offset: 0x000EDF88
		public override void SetProperty(vtkVolumeProperty property)
		{
			vtkMultiVolume.vtkMultiVolume_SetProperty_19(base.GetCppThis(), (property == null) ? default(HandleRef) : property.GetCppThis());
		}

		// Token: 0x0600A8F1 RID: 43249
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiVolume_SetVolume_20(HandleRef pThis, HandleRef volume, int port);

		/// <summary>
		/// Add / Remove a vtkVolume instance.
		/// </summary>
		// Token: 0x0600A8F2 RID: 43250 RVA: 0x000EFDB8 File Offset: 0x000EDFB8
		public void SetVolume(vtkVolume volume, int port)
		{
			vtkMultiVolume.vtkMultiVolume_SetVolume_20(base.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), port);
		}

		// Token: 0x0600A8F3 RID: 43251
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiVolume_ShallowCopy_21(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Checks whether the vtkProp passed is another vtkMultiVolume and tries to
		/// copy accordingly. Otherwise it falls back to vtkVolume::ShallowCopy.
		/// \sa vtkVolume
		/// </summary>
		// Token: 0x0600A8F4 RID: 43252 RVA: 0x000EFDE8 File Offset: 0x000EDFE8
		public override void ShallowCopy(vtkProp prop)
		{
			vtkMultiVolume.vtkMultiVolume_ShallowCopy_21(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D71 RID: 3441
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiVolume";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D72 RID: 3442
		public new static readonly string MRClassNameKey = "class vtkMultiVolume";
	}
}
