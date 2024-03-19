using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageSkeleton2D
	/// </summary>
	/// <remarks>
	///    Skeleton of 2D images.
	///
	/// vtkImageSkeleton2D should leave only single pixel width lines
	/// of non-zero-valued pixels (values of 1 are not allowed).
	/// It works by erosion on a 3x3 neighborhood with special rules.
	/// The number of iterations determines how far the filter can erode.
	/// There are three pruning levels:
	///  prune == 0 will leave traces on all angles...
	///  prune == 1 will not leave traces on 135 degree angles, but will on 90.
	///  prune == 2 does not leave traces on any angles leaving only closed loops.
	/// Prune defaults to zero. The output scalar type is the same as the input.
	/// </remarks>
	// Token: 0x02000250 RID: 592
	public class vtkImageSkeleton2D : vtkImageIterateFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006D7E RID: 28030 RVA: 0x0009E017 File Offset: 0x0009C217
		static vtkImageSkeleton2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSkeleton2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSkeleton2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006D7F RID: 28031 RVA: 0x0009E03F File Offset: 0x0009C23F
		public vtkImageSkeleton2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006D80 RID: 28032
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSkeleton2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D81 RID: 28033 RVA: 0x0009E050 File Offset: 0x0009C250
		public new static vtkImageSkeleton2D New()
		{
			vtkImageSkeleton2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSkeleton2D.vtkImageSkeleton2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSkeleton2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D82 RID: 28034 RVA: 0x0009E0A4 File Offset: 0x0009C2A4
		public vtkImageSkeleton2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageSkeleton2D.vtkImageSkeleton2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006D83 RID: 28035 RVA: 0x0009E0E8 File Offset: 0x0009C2E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006D84 RID: 28036
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSkeleton2D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D85 RID: 28037 RVA: 0x0009E0F4 File Offset: 0x0009C2F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageSkeleton2D.vtkImageSkeleton2D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06006D86 RID: 28038
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSkeleton2D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D87 RID: 28039 RVA: 0x0009E114 File Offset: 0x0009C314
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageSkeleton2D.vtkImageSkeleton2D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006D88 RID: 28040
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSkeleton2D_GetPrune_03(HandleRef pThis);

		/// <summary>
		/// When prune is on, only closed loops are left unchanged.
		/// </summary>
		// Token: 0x06006D89 RID: 28041 RVA: 0x0009E130 File Offset: 0x0009C330
		public virtual int GetPrune()
		{
			return vtkImageSkeleton2D.vtkImageSkeleton2D_GetPrune_03(base.GetCppThis());
		}

		// Token: 0x06006D8A RID: 28042
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSkeleton2D_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D8B RID: 28043 RVA: 0x0009E150 File Offset: 0x0009C350
		public override int IsA(string type)
		{
			return vtkImageSkeleton2D.vtkImageSkeleton2D_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06006D8C RID: 28044
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSkeleton2D_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D8D RID: 28045 RVA: 0x0009E170 File Offset: 0x0009C370
		public new static int IsTypeOf(string type)
		{
			return vtkImageSkeleton2D.vtkImageSkeleton2D_IsTypeOf_05(type);
		}

		// Token: 0x06006D8E RID: 28046
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSkeleton2D_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D8F RID: 28047 RVA: 0x0009E18C File Offset: 0x0009C38C
		public new vtkImageSkeleton2D NewInstance()
		{
			vtkImageSkeleton2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSkeleton2D.vtkImageSkeleton2D_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSkeleton2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006D90 RID: 28048
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSkeleton2D_PruneOff_08(HandleRef pThis);

		/// <summary>
		/// When prune is on, only closed loops are left unchanged.
		/// </summary>
		// Token: 0x06006D91 RID: 28049 RVA: 0x0009E1E6 File Offset: 0x0009C3E6
		public virtual void PruneOff()
		{
			vtkImageSkeleton2D.vtkImageSkeleton2D_PruneOff_08(base.GetCppThis());
		}

		// Token: 0x06006D92 RID: 28050
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSkeleton2D_PruneOn_09(HandleRef pThis);

		/// <summary>
		/// When prune is on, only closed loops are left unchanged.
		/// </summary>
		// Token: 0x06006D93 RID: 28051 RVA: 0x0009E1F5 File Offset: 0x0009C3F5
		public virtual void PruneOn()
		{
			vtkImageSkeleton2D.vtkImageSkeleton2D_PruneOn_09(base.GetCppThis());
		}

		// Token: 0x06006D94 RID: 28052
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSkeleton2D_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D95 RID: 28053 RVA: 0x0009E204 File Offset: 0x0009C404
		public new static vtkImageSkeleton2D SafeDownCast(vtkObjectBase o)
		{
			vtkImageSkeleton2D vtkImageSkeleton2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSkeleton2D.vtkImageSkeleton2D_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSkeleton2D = (vtkImageSkeleton2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSkeleton2D.Register(null);
				}
			}
			return vtkImageSkeleton2D;
		}

		// Token: 0x06006D96 RID: 28054
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSkeleton2D_SetNumberOfIterations_11(HandleRef pThis, int num);

		/// <summary>
		/// Sets the number of cycles in the erosion.
		/// </summary>
		// Token: 0x06006D97 RID: 28055 RVA: 0x0009E283 File Offset: 0x0009C483
		public virtual void SetNumberOfIterations(int num)
		{
			vtkImageSkeleton2D.vtkImageSkeleton2D_SetNumberOfIterations_11(base.GetCppThis(), num);
		}

		// Token: 0x06006D98 RID: 28056
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSkeleton2D_SetPrune_12(HandleRef pThis, int _arg);

		/// <summary>
		/// When prune is on, only closed loops are left unchanged.
		/// </summary>
		// Token: 0x06006D99 RID: 28057 RVA: 0x0009E293 File Offset: 0x0009C493
		public virtual void SetPrune(int _arg)
		{
			vtkImageSkeleton2D.vtkImageSkeleton2D_SetPrune_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000995 RID: 2453
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSkeleton2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000996 RID: 2454
		public new static readonly string MRClassNameKey = "class vtkImageSkeleton2D";
	}
}
