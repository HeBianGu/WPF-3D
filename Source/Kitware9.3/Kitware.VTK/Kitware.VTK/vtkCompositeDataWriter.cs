using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeDataWriter
	/// </summary>
	/// <remarks>
	///    legacy VTK file writer for vtkCompositeDataSet
	/// subclasses.
	///
	/// vtkCompositeDataWriter is a writer for writing legacy VTK files for
	/// vtkCompositeDataSet and subclasses.
	/// @warning
	/// This is an experimental format. Use XML-based formats for writing composite
	/// datasets. Saving composite dataset in legacy VTK format is expected to change
	/// in future including changes to the file layout.
	/// </remarks>
	// Token: 0x02000704 RID: 1796
	public class vtkCompositeDataWriter : vtkDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012E34 RID: 77364 RVA: 0x001A9793 File Offset: 0x001A7993
		static vtkCompositeDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012E35 RID: 77365 RVA: 0x001A97BB File Offset: 0x001A79BB
		public vtkCompositeDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012E36 RID: 77366
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E37 RID: 77367 RVA: 0x001A97CC File Offset: 0x001A79CC
		public new static vtkCompositeDataWriter New()
		{
			vtkCompositeDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataWriter.vtkCompositeDataWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E38 RID: 77368 RVA: 0x001A9820 File Offset: 0x001A7A20
		public vtkCompositeDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeDataWriter.vtkCompositeDataWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012E39 RID: 77369 RVA: 0x001A9864 File Offset: 0x001A7A64
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012E3A RID: 77370
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataWriter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06012E3B RID: 77371 RVA: 0x001A9870 File Offset: 0x001A7A70
		public new vtkCompositeDataSet GetInput()
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataWriter.vtkCompositeDataWriter_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		// Token: 0x06012E3C RID: 77372
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataWriter_GetInput_02(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06012E3D RID: 77373 RVA: 0x001A98E0 File Offset: 0x001A7AE0
		public new vtkCompositeDataSet GetInput(int port)
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataWriter.vtkCompositeDataWriter_GetInput_02(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		// Token: 0x06012E3E RID: 77374
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E3F RID: 77375 RVA: 0x001A9950 File Offset: 0x001A7B50
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeDataWriter.vtkCompositeDataWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06012E40 RID: 77376
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E41 RID: 77377 RVA: 0x001A9970 File Offset: 0x001A7B70
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeDataWriter.vtkCompositeDataWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06012E42 RID: 77378
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E43 RID: 77379 RVA: 0x001A998C File Offset: 0x001A7B8C
		public override int IsA(string type)
		{
			return vtkCompositeDataWriter.vtkCompositeDataWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012E44 RID: 77380
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E45 RID: 77381 RVA: 0x001A99AC File Offset: 0x001A7BAC
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeDataWriter.vtkCompositeDataWriter_IsTypeOf_06(type);
		}

		// Token: 0x06012E46 RID: 77382
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E47 RID: 77383 RVA: 0x001A99C8 File Offset: 0x001A7BC8
		public new vtkCompositeDataWriter NewInstance()
		{
			vtkCompositeDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataWriter.vtkCompositeDataWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012E48 RID: 77384
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E49 RID: 77385 RVA: 0x001A9A24 File Offset: 0x001A7C24
		public new static vtkCompositeDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeDataWriter vtkCompositeDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataWriter.vtkCompositeDataWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataWriter = (vtkCompositeDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataWriter.Register(null);
				}
			}
			return vtkCompositeDataWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015D4 RID: 5588
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015D5 RID: 5589
		public new static readonly string MRClassNameKey = "class vtkCompositeDataWriter";
	}
}
