using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFixedPointVolumeRayCastCompositeGOHelper
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
	// Token: 0x02000397 RID: 919
	public class vtkFixedPointVolumeRayCastCompositeGOHelper : vtkFixedPointVolumeRayCastHelper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A73F RID: 42815 RVA: 0x000ED33B File Offset: 0x000EB53B
		static vtkFixedPointVolumeRayCastCompositeGOHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedPointVolumeRayCastCompositeGOHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastCompositeGOHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A740 RID: 42816 RVA: 0x000ED363 File Offset: 0x000EB563
		public vtkFixedPointVolumeRayCastCompositeGOHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A741 RID: 42817
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeGOHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A742 RID: 42818 RVA: 0x000ED374 File Offset: 0x000EB574
		public new static vtkFixedPointVolumeRayCastCompositeGOHelper New()
		{
			vtkFixedPointVolumeRayCastCompositeGOHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastCompositeGOHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A743 RID: 42819 RVA: 0x000ED3C8 File Offset: 0x000EB5C8
		public vtkFixedPointVolumeRayCastCompositeGOHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A744 RID: 42820 RVA: 0x000ED40C File Offset: 0x000EB60C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A745 RID: 42821
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointVolumeRayCastCompositeGOHelper_GenerateImage_01(HandleRef pThis, int threadID, int threadCount, HandleRef vol, HandleRef mapper);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A746 RID: 42822 RVA: 0x000ED418 File Offset: 0x000EB618
		public override void GenerateImage(int threadID, int threadCount, vtkVolume vol, vtkFixedPointVolumeRayCastMapper mapper)
		{
			vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_GenerateImage_01(base.GetCppThis(), threadID, threadCount, (vol == null) ? default(HandleRef) : vol.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x0600A747 RID: 42823
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointVolumeRayCastCompositeGOHelper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A748 RID: 42824 RVA: 0x000ED460 File Offset: 0x000EB660
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A749 RID: 42825
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointVolumeRayCastCompositeGOHelper_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A74A RID: 42826 RVA: 0x000ED480 File Offset: 0x000EB680
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A74B RID: 42827
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastCompositeGOHelper_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A74C RID: 42828 RVA: 0x000ED49C File Offset: 0x000EB69C
		public override int IsA(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600A74D RID: 42829
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointVolumeRayCastCompositeGOHelper_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A74E RID: 42830 RVA: 0x000ED4BC File Offset: 0x000EB6BC
		public new static int IsTypeOf(string type)
		{
			return vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_IsTypeOf_05(type);
		}

		// Token: 0x0600A74F RID: 42831
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeGOHelper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A750 RID: 42832 RVA: 0x000ED4D8 File Offset: 0x000EB6D8
		public new vtkFixedPointVolumeRayCastCompositeGOHelper NewInstance()
		{
			vtkFixedPointVolumeRayCastCompositeGOHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastCompositeGOHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A751 RID: 42833
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointVolumeRayCastCompositeGOHelper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A752 RID: 42834 RVA: 0x000ED534 File Offset: 0x000EB734
		public new static vtkFixedPointVolumeRayCastCompositeGOHelper SafeDownCast(vtkObjectBase o)
		{
			vtkFixedPointVolumeRayCastCompositeGOHelper vtkFixedPointVolumeRayCastCompositeGOHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointVolumeRayCastCompositeGOHelper.vtkFixedPointVolumeRayCastCompositeGOHelper_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastCompositeGOHelper = (vtkFixedPointVolumeRayCastCompositeGOHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastCompositeGOHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastCompositeGOHelper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D63 RID: 3427
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastCompositeGOHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D64 RID: 3428
		public new static readonly string MRClassNameKey = "class vtkFixedPointVolumeRayCastCompositeGOHelper";
	}
}
