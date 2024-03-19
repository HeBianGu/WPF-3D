using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFixedPointVolumeRayCastCompositeHelper
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
	// Token: 0x02000399 RID: 921
	public class vtkFixedPointVolumeRayCastCompositeHelper : vtkFixedPointVolumeRayCastHelper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A767 RID: 42855 RVA: 0x000ED82B File Offset: 0x000EBA2B
		static vtkFixedPointVolumeRayCastCompositeHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedPointVolumeRayCastCompositeHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastCompositeHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A768 RID: 42856 RVA: 0x000ED853 File Offset: 0x000EBA53
		public vtkFixedPointVolumeRayCastCompositeHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A769 RID: 42857
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A76A RID: 42858 RVA: 0x000ED864 File Offset: 0x000EBA64
		public new static vtkFixedPointVolumeRayCastCompositeHelper New()
		{
			vtkFixedPointVolumeRayCastCompositeHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastCompositeHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A76B RID: 42859 RVA: 0x000ED8B8 File Offset: 0x000EBAB8
		public vtkFixedPointVolumeRayCastCompositeHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A76C RID: 42860 RVA: 0x000ED8FC File Offset: 0x000EBAFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A76D RID: 42861
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastCompositeHelper_GenerateImage_01(HandleRef pThis, int threadID, int threadCount, HandleRef vol, HandleRef mapper);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A76E RID: 42862 RVA: 0x000ED908 File Offset: 0x000EBB08
		public override void GenerateImage(int threadID, int threadCount, vtkVolume vol, vtkFixedPointVolumeRayCastMapper mapper)
		{
			vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_GenerateImage_01(base.GetCppThis(), threadID, threadCount, (vol == null) ? default(HandleRef) : vol.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x0600A76F RID: 42863
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointVolumeRayCastCompositeHelper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A770 RID: 42864 RVA: 0x000ED950 File Offset: 0x000EBB50
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A771 RID: 42865
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointVolumeRayCastCompositeHelper_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A772 RID: 42866 RVA: 0x000ED970 File Offset: 0x000EBB70
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A773 RID: 42867
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastCompositeHelper_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A774 RID: 42868 RVA: 0x000ED98C File Offset: 0x000EBB8C
		public override int IsA(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600A775 RID: 42869
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastCompositeHelper_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A776 RID: 42870 RVA: 0x000ED9AC File Offset: 0x000EBBAC
		public new static int IsTypeOf(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_IsTypeOf_05(type);
		}

		// Token: 0x0600A777 RID: 42871
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeHelper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A778 RID: 42872 RVA: 0x000ED9C8 File Offset: 0x000EBBC8
		public new vtkFixedPointVolumeRayCastCompositeHelper NewInstance()
		{
			vtkFixedPointVolumeRayCastCompositeHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastCompositeHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A779 RID: 42873
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeHelper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A77A RID: 42874 RVA: 0x000EDA24 File Offset: 0x000EBC24
		public new static vtkFixedPointVolumeRayCastCompositeHelper SafeDownCast(vtkObjectBase o)
		{
			vtkFixedPointVolumeRayCastCompositeHelper vtkFixedPointVolumeRayCastCompositeHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeHelper.vtkFixedPointVolumeRayCastCompositeHelper_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastCompositeHelper = (vtkFixedPointVolumeRayCastCompositeHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastCompositeHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastCompositeHelper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D67 RID: 3431
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastCompositeHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D68 RID: 3432
		public new static readonly string MRClassNameKey = "class vtkFixedPointVolumeRayCastCompositeHelper";
	}
}
