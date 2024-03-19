using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkScaledTextActor
	/// </summary>
	/// <remarks>
	///    create text that will scale as needed
	///
	/// vtkScaledTextActor is deprecated. New code should use vtkTextActor with
	/// the Scaled = true option.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTextActor vtkActor2D vtkTextMapper
	/// </seealso>
	// Token: 0x020007C1 RID: 1985
	public class vtkScaledTextActor : vtkTextActor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014592 RID: 83346 RVA: 0x001CC693 File Offset: 0x001CA893
		static vtkScaledTextActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScaledTextActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScaledTextActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014593 RID: 83347 RVA: 0x001CC6BB File Offset: 0x001CA8BB
		public vtkScaledTextActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014594 RID: 83348
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScaledTextActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with a rectangle in normaled view coordinates
		/// of (0.2,0.85, 0.8, 0.95).
		/// </summary>
		// Token: 0x06014595 RID: 83349 RVA: 0x001CC6CC File Offset: 0x001CA8CC
		public new static vtkScaledTextActor New()
		{
			vtkScaledTextActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScaledTextActor.vtkScaledTextActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScaledTextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with a rectangle in normaled view coordinates
		/// of (0.2,0.85, 0.8, 0.95).
		/// </summary>
		// Token: 0x06014596 RID: 83350 RVA: 0x001CC720 File Offset: 0x001CA920
		public vtkScaledTextActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkScaledTextActor.vtkScaledTextActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014597 RID: 83351 RVA: 0x001CC764 File Offset: 0x001CA964
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014598 RID: 83352
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScaledTextActor_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014599 RID: 83353 RVA: 0x001CC770 File Offset: 0x001CA970
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkScaledTextActor.vtkScaledTextActor_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601459A RID: 83354
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScaledTextActor_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601459B RID: 83355 RVA: 0x001CC790 File Offset: 0x001CA990
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkScaledTextActor.vtkScaledTextActor_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601459C RID: 83356
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScaledTextActor_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601459D RID: 83357 RVA: 0x001CC7AC File Offset: 0x001CA9AC
		public override int IsA(string type)
		{
			return vtkScaledTextActor.vtkScaledTextActor_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601459E RID: 83358
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScaledTextActor_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601459F RID: 83359 RVA: 0x001CC7CC File Offset: 0x001CA9CC
		public new static int IsTypeOf(string type)
		{
			return vtkScaledTextActor.vtkScaledTextActor_IsTypeOf_04(type);
		}

		// Token: 0x060145A0 RID: 83360
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScaledTextActor_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145A1 RID: 83361 RVA: 0x001CC7E8 File Offset: 0x001CA9E8
		public new vtkScaledTextActor NewInstance()
		{
			vtkScaledTextActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScaledTextActor.vtkScaledTextActor_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScaledTextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060145A2 RID: 83362
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScaledTextActor_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145A3 RID: 83363 RVA: 0x001CC844 File Offset: 0x001CAA44
		public new static vtkScaledTextActor SafeDownCast(vtkObjectBase o)
		{
			vtkScaledTextActor vtkScaledTextActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScaledTextActor.vtkScaledTextActor_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScaledTextActor = (vtkScaledTextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScaledTextActor.Register(null);
				}
			}
			return vtkScaledTextActor;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017A0 RID: 6048
		public new const string MRFullTypeName = "Kitware.VTK.vtkScaledTextActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017A1 RID: 6049
		public new static readonly string MRClassNameKey = "class vtkScaledTextActor";
	}
}
