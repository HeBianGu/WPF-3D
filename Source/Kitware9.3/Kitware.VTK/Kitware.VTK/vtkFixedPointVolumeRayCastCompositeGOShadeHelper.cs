using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFixedPointVolumeRayCastCompositeGOShadeHelper
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
	// Token: 0x02000398 RID: 920
	public class vtkFixedPointVolumeRayCastCompositeGOShadeHelper : vtkFixedPointVolumeRayCastHelper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A753 RID: 42835 RVA: 0x000ED5B3 File Offset: 0x000EB7B3
		static vtkFixedPointVolumeRayCastCompositeGOShadeHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedPointVolumeRayCastCompositeGOShadeHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastCompositeGOShadeHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A754 RID: 42836 RVA: 0x000ED5DB File Offset: 0x000EB7DB
		public vtkFixedPointVolumeRayCastCompositeGOShadeHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A755 RID: 42837
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeGOShadeHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A756 RID: 42838 RVA: 0x000ED5EC File Offset: 0x000EB7EC
		public new static vtkFixedPointVolumeRayCastCompositeGOShadeHelper New()
		{
			vtkFixedPointVolumeRayCastCompositeGOShadeHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeGOShadeHelper.vtkFixedPointVolumeRayCastCompositeGOShadeHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastCompositeGOShadeHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A757 RID: 42839 RVA: 0x000ED640 File Offset: 0x000EB840
		public vtkFixedPointVolumeRayCastCompositeGOShadeHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFixedPointVolumeRayCastCompositeGOShadeHelper.vtkFixedPointVolumeRayCastCompositeGOShadeHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A758 RID: 42840 RVA: 0x000ED684 File Offset: 0x000EB884
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A759 RID: 42841
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastCompositeGOShadeHelper_GenerateImage_01(HandleRef pThis, int threadID, int threadCount, HandleRef vol, HandleRef mapper);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A75A RID: 42842 RVA: 0x000ED690 File Offset: 0x000EB890
		public override void GenerateImage(int threadID, int threadCount, vtkVolume vol, vtkFixedPointVolumeRayCastMapper mapper)
		{
			vtkFixedPointVolumeRayCastCompositeGOShadeHelper.vtkFixedPointVolumeRayCastCompositeGOShadeHelper_GenerateImage_01(base.GetCppThis(), threadID, threadCount, (vol == null) ? default(HandleRef) : vol.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x0600A75B RID: 42843
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointVolumeRayCastCompositeGOShadeHelper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A75C RID: 42844 RVA: 0x000ED6D8 File Offset: 0x000EB8D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeGOShadeHelper.vtkFixedPointVolumeRayCastCompositeGOShadeHelper_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A75D RID: 42845
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointVolumeRayCastCompositeGOShadeHelper_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A75E RID: 42846 RVA: 0x000ED6F8 File Offset: 0x000EB8F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeGOShadeHelper.vtkFixedPointVolumeRayCastCompositeGOShadeHelper_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A75F RID: 42847
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastCompositeGOShadeHelper_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A760 RID: 42848 RVA: 0x000ED714 File Offset: 0x000EB914
		public override int IsA(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeGOShadeHelper.vtkFixedPointVolumeRayCastCompositeGOShadeHelper_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600A761 RID: 42849
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastCompositeGOShadeHelper_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A762 RID: 42850 RVA: 0x000ED734 File Offset: 0x000EB934
		public new static int IsTypeOf(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeGOShadeHelper.vtkFixedPointVolumeRayCastCompositeGOShadeHelper_IsTypeOf_05(type);
		}

		// Token: 0x0600A763 RID: 42851
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeGOShadeHelper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A764 RID: 42852 RVA: 0x000ED750 File Offset: 0x000EB950
		public new vtkFixedPointVolumeRayCastCompositeGOShadeHelper NewInstance()
		{
			vtkFixedPointVolumeRayCastCompositeGOShadeHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeGOShadeHelper.vtkFixedPointVolumeRayCastCompositeGOShadeHelper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastCompositeGOShadeHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A765 RID: 42853
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeGOShadeHelper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A766 RID: 42854 RVA: 0x000ED7AC File Offset: 0x000EB9AC
		public new static vtkFixedPointVolumeRayCastCompositeGOShadeHelper SafeDownCast(vtkObjectBase o)
		{
			vtkFixedPointVolumeRayCastCompositeGOShadeHelper vtkFixedPointVolumeRayCastCompositeGOShadeHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeGOShadeHelper.vtkFixedPointVolumeRayCastCompositeGOShadeHelper_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastCompositeGOShadeHelper = (vtkFixedPointVolumeRayCastCompositeGOShadeHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastCompositeGOShadeHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastCompositeGOShadeHelper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D65 RID: 3429
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastCompositeGOShadeHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D66 RID: 3430
		public new static readonly string MRClassNameKey = "class vtkFixedPointVolumeRayCastCompositeGOShadeHelper";
	}
}
