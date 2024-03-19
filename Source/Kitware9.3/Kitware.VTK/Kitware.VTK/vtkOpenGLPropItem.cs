using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLPropItem
	/// </summary>
	/// <remarks>
	///    Sync Context2D state with vtk camera.
	///
	///
	/// The vtkContext2D framework modifies the GL state directly, while some actors
	/// and mappers rely on the modelview/projection matrices from vtkCamera. This
	/// class is a layer between the two that updates the camera with the current
	/// OpenGL state.
	/// </remarks>
	// Token: 0x02000125 RID: 293
	public class vtkOpenGLPropItem : vtkPropItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003BD1 RID: 15313 RVA: 0x00057043 File Offset: 0x00055243
		static vtkOpenGLPropItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLPropItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLPropItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003BD2 RID: 15314 RVA: 0x0005706B File Offset: 0x0005526B
		public vtkOpenGLPropItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003BD3 RID: 15315
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPropItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BD4 RID: 15316 RVA: 0x0005707C File Offset: 0x0005527C
		public new static vtkOpenGLPropItem New()
		{
			vtkOpenGLPropItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLPropItem.vtkOpenGLPropItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLPropItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BD5 RID: 15317 RVA: 0x000570D0 File Offset: 0x000552D0
		public vtkOpenGLPropItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLPropItem.vtkOpenGLPropItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003BD6 RID: 15318 RVA: 0x00057114 File Offset: 0x00055314
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003BD7 RID: 15319
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLPropItem_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BD8 RID: 15320 RVA: 0x00057120 File Offset: 0x00055320
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLPropItem.vtkOpenGLPropItem_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06003BD9 RID: 15321
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLPropItem_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BDA RID: 15322 RVA: 0x00057140 File Offset: 0x00055340
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLPropItem.vtkOpenGLPropItem_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06003BDB RID: 15323
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLPropItem_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BDC RID: 15324 RVA: 0x0005715C File Offset: 0x0005535C
		public override int IsA(string type)
		{
			return vtkOpenGLPropItem.vtkOpenGLPropItem_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06003BDD RID: 15325
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLPropItem_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BDE RID: 15326 RVA: 0x0005717C File Offset: 0x0005537C
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLPropItem.vtkOpenGLPropItem_IsTypeOf_04(type);
		}

		// Token: 0x06003BDF RID: 15327
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPropItem_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BE0 RID: 15328 RVA: 0x00057198 File Offset: 0x00055398
		public new vtkOpenGLPropItem NewInstance()
		{
			vtkOpenGLPropItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLPropItem.vtkOpenGLPropItem_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLPropItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003BE1 RID: 15329
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLPropItem_Paint_07(HandleRef pThis, HandleRef painter);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BE2 RID: 15330 RVA: 0x000571F4 File Offset: 0x000553F4
		public override bool Paint(vtkContext2D painter)
		{
			return vtkOpenGLPropItem.vtkOpenGLPropItem_Paint_07(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06003BE3 RID: 15331
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLPropItem_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BE4 RID: 15332 RVA: 0x00057230 File Offset: 0x00055430
		public new static vtkOpenGLPropItem SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLPropItem vtkOpenGLPropItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLPropItem.vtkOpenGLPropItem_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLPropItem = (vtkOpenGLPropItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLPropItem.Register(null);
				}
			}
			return vtkOpenGLPropItem;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000683 RID: 1667
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLPropItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000684 RID: 1668
		public new static readonly string MRClassNameKey = "class vtkOpenGLPropItem";
	}
}
