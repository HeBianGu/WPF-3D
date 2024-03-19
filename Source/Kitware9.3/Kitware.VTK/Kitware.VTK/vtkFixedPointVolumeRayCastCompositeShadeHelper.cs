using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFixedPointVolumeRayCastCompositeShadeHelper
	/// </summary>
	/// <remarks>
	///    A helper that generates composite images for the volume ray cast mapper
	///
	/// This is one of the helper classes for the vtkFixedPointVolumeRayCastMapper.
	/// It will generate composite images using an alpha blending operation.
	/// This class should not be used directly, it is a helper class for
	/// the mapper and has no user-level API.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFixedPointVolumeRayCastMapper
	/// </seealso>
	// Token: 0x0200039A RID: 922
	public class vtkFixedPointVolumeRayCastCompositeShadeHelper : vtkFixedPointVolumeRayCastHelper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A77B RID: 42875 RVA: 0x000EDAA3 File Offset: 0x000EBCA3
		static vtkFixedPointVolumeRayCastCompositeShadeHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedPointVolumeRayCastCompositeShadeHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastCompositeShadeHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A77C RID: 42876 RVA: 0x000EDACB File Offset: 0x000EBCCB
		public vtkFixedPointVolumeRayCastCompositeShadeHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A77D RID: 42877
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeShadeHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A77E RID: 42878 RVA: 0x000EDADC File Offset: 0x000EBCDC
		public new static vtkFixedPointVolumeRayCastCompositeShadeHelper New()
		{
			vtkFixedPointVolumeRayCastCompositeShadeHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeShadeHelper.vtkFixedPointVolumeRayCastCompositeShadeHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastCompositeShadeHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A77F RID: 42879 RVA: 0x000EDB30 File Offset: 0x000EBD30
		public vtkFixedPointVolumeRayCastCompositeShadeHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFixedPointVolumeRayCastCompositeShadeHelper.vtkFixedPointVolumeRayCastCompositeShadeHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A780 RID: 42880 RVA: 0x000EDB74 File Offset: 0x000EBD74
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A781 RID: 42881
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastCompositeShadeHelper_GenerateImage_01(HandleRef pThis, int threadID, int threadCount, HandleRef vol, HandleRef mapper);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A782 RID: 42882 RVA: 0x000EDB80 File Offset: 0x000EBD80
		public override void GenerateImage(int threadID, int threadCount, vtkVolume vol, vtkFixedPointVolumeRayCastMapper mapper)
		{
			vtkFixedPointVolumeRayCastCompositeShadeHelper.vtkFixedPointVolumeRayCastCompositeShadeHelper_GenerateImage_01(base.GetCppThis(), threadID, threadCount, (vol == null) ? default(HandleRef) : vol.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x0600A783 RID: 42883
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointVolumeRayCastCompositeShadeHelper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A784 RID: 42884 RVA: 0x000EDBC8 File Offset: 0x000EBDC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeShadeHelper.vtkFixedPointVolumeRayCastCompositeShadeHelper_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A785 RID: 42885
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointVolumeRayCastCompositeShadeHelper_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A786 RID: 42886 RVA: 0x000EDBE8 File Offset: 0x000EBDE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeShadeHelper.vtkFixedPointVolumeRayCastCompositeShadeHelper_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A787 RID: 42887
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastCompositeShadeHelper_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A788 RID: 42888 RVA: 0x000EDC04 File Offset: 0x000EBE04
		public override int IsA(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeShadeHelper.vtkFixedPointVolumeRayCastCompositeShadeHelper_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600A789 RID: 42889
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastCompositeShadeHelper_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A78A RID: 42890 RVA: 0x000EDC24 File Offset: 0x000EBE24
		public new static int IsTypeOf(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeShadeHelper.vtkFixedPointVolumeRayCastCompositeShadeHelper_IsTypeOf_05(type);
		}

		// Token: 0x0600A78B RID: 42891
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeShadeHelper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A78C RID: 42892 RVA: 0x000EDC40 File Offset: 0x000EBE40
		public new vtkFixedPointVolumeRayCastCompositeShadeHelper NewInstance()
		{
			vtkFixedPointVolumeRayCastCompositeShadeHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeShadeHelper.vtkFixedPointVolumeRayCastCompositeShadeHelper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastCompositeShadeHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A78D RID: 42893
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeShadeHelper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A78E RID: 42894 RVA: 0x000EDC9C File Offset: 0x000EBE9C
		public new static vtkFixedPointVolumeRayCastCompositeShadeHelper SafeDownCast(vtkObjectBase o)
		{
			vtkFixedPointVolumeRayCastCompositeShadeHelper vtkFixedPointVolumeRayCastCompositeShadeHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeShadeHelper.vtkFixedPointVolumeRayCastCompositeShadeHelper_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastCompositeShadeHelper = (vtkFixedPointVolumeRayCastCompositeShadeHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastCompositeShadeHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastCompositeShadeHelper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D69 RID: 3433
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastCompositeShadeHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D6A RID: 3434
		public new static readonly string MRClassNameKey = "class vtkFixedPointVolumeRayCastCompositeShadeHelper";
	}
}
