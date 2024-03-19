using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGIOResponder
	/// </summary>
	/// <remarks>
	///    Read/write metadata specific to discontinuous Galerkin cells.
	///
	/// vtkDGIOResponder is a concrete responder to vtkCellGridIOQuery objects.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCellGridIOQuery
	/// vtkCellGridResponder
	/// </seealso>
	// Token: 0x020001DF RID: 479
	public class vtkDGIOResponder : vtkCellGridResponderBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005B3A RID: 23354 RVA: 0x0008432B File Offset: 0x0008252B
		static vtkDGIOResponder()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGIOResponder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGIOResponder"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005B3B RID: 23355 RVA: 0x00084353 File Offset: 0x00082553
		public vtkDGIOResponder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005B3C RID: 23356
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGIOResponder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B3D RID: 23357 RVA: 0x00084364 File Offset: 0x00082564
		public new static vtkDGIOResponder New()
		{
			vtkDGIOResponder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGIOResponder.vtkDGIOResponder_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGIOResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B3E RID: 23358 RVA: 0x000843B8 File Offset: 0x000825B8
		public vtkDGIOResponder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDGIOResponder.vtkDGIOResponder_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005B3F RID: 23359 RVA: 0x000843FC File Offset: 0x000825FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005B40 RID: 23360
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGIOResponder_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B41 RID: 23361 RVA: 0x00084408 File Offset: 0x00082608
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGIOResponder.vtkDGIOResponder_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06005B42 RID: 23362
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGIOResponder_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B43 RID: 23363 RVA: 0x00084428 File Offset: 0x00082628
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGIOResponder.vtkDGIOResponder_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06005B44 RID: 23364
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGIOResponder_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B45 RID: 23365 RVA: 0x00084444 File Offset: 0x00082644
		public override int IsA(string type)
		{
			return vtkDGIOResponder.vtkDGIOResponder_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06005B46 RID: 23366
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGIOResponder_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B47 RID: 23367 RVA: 0x00084464 File Offset: 0x00082664
		public new static int IsTypeOf(string type)
		{
			return vtkDGIOResponder.vtkDGIOResponder_IsTypeOf_04(type);
		}

		// Token: 0x06005B48 RID: 23368
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGIOResponder_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B49 RID: 23369 RVA: 0x00084480 File Offset: 0x00082680
		public new vtkDGIOResponder NewInstance()
		{
			vtkDGIOResponder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGIOResponder.vtkDGIOResponder_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGIOResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005B4A RID: 23370
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDGIOResponder_Query_07(HandleRef pThis, HandleRef query, HandleRef cellType, HandleRef caches);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B4B RID: 23371 RVA: 0x000844DC File Offset: 0x000826DC
		public virtual bool Query(vtkCellGridIOQuery query, vtkCellMetadata cellType, vtkCellGridResponders caches)
		{
			return vtkDGIOResponder.vtkDGIOResponder_Query_07(base.GetCppThis(), (query == null) ? default(HandleRef) : query.GetCppThis(), (cellType == null) ? default(HandleRef) : cellType.GetCppThis(), (caches == null) ? default(HandleRef) : caches.GetCppThis()) != 0;
		}

		// Token: 0x06005B4C RID: 23372
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGIOResponder_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B4D RID: 23373 RVA: 0x00084544 File Offset: 0x00082744
		public new static vtkDGIOResponder SafeDownCast(vtkObjectBase o)
		{
			vtkDGIOResponder vtkDGIOResponder = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGIOResponder.vtkDGIOResponder_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGIOResponder = (vtkDGIOResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGIOResponder.Register(null);
				}
			}
			return vtkDGIOResponder;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000887 RID: 2183
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGIOResponder";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000888 RID: 2184
		public new static readonly string MRClassNameKey = "class vtkDGIOResponder";
	}
}
